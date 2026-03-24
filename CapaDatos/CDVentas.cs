using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVentas
    {
        public string ProcesarVenta(decimal total, int idEmpleado, DataTable carrito)
        {
            string respuesta = "";
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                cn.Open();
                using (SqlTransaction transaccion = cn.BeginTransaction())
                {
                    try
                    {
                        // 1. CREAR EL TICKET (Tabla: ventas_dulceria)
                        int idVentaGenerada = 0;
                        using (SqlCommand cmdVenta = new SqlCommand("sp_insertar_venta_dulceria", cn, transaccion))
                        {
                            cmdVenta.CommandType = CommandType.StoredProcedure;
                            cmdVenta.Parameters.AddWithValue("@idempleado", idEmpleado);
                            cmdVenta.Parameters.AddWithValue("@total", total);

                            SqlParameter parIdVenta = new SqlParameter("@idventa", SqlDbType.Int);
                            parIdVenta.Direction = ParameterDirection.Output;
                            cmdVenta.Parameters.Add(parIdVenta);

                            cmdVenta.ExecuteNonQuery();
                            idVentaGenerada = Convert.ToInt32(parIdVenta.Value);
                        }

                        // 2. RECORRER EL CARRITO
                        foreach (DataRow fila in carrito.Rows)
                        {
                            int idProd = Convert.ToInt32(fila["IdProducto"]);
                            string nombreProd = fila["Producto"].ToString();
                            int cant = Convert.ToInt32(fila["Cantidad"]);
                            decimal precioUnitario = Convert.ToDecimal(fila["Precio"]);

                            // A) Guardar en detalle_venta_dulceria (sin subtotal ni iva)
                            using (SqlCommand cmdDetalle = new SqlCommand("sp_insertar_detalle_venta_dulceria", cn, transaccion))
                            {
                                cmdDetalle.CommandType = CommandType.StoredProcedure;
                                cmdDetalle.Parameters.AddWithValue("@idventa", idVentaGenerada);
                                cmdDetalle.Parameters.AddWithValue("@idproducto", idProd);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", cant);
                                cmdDetalle.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                                cmdDetalle.ExecuteNonQuery();
                            }

                            // B) Descontar stock
                            using (SqlCommand cmdStock = new SqlCommand("UPDATE dulceria SET stock = stock - @cant WHERE idproducto = @id", cn, transaccion))
                            {
                                cmdStock.Parameters.AddWithValue("@cant", cant);
                                cmdStock.Parameters.AddWithValue("@id", idProd);
                                cmdStock.ExecuteNonQuery();
                            }

                            // C) Bitácora
                            using (SqlCommand cmdBitacora = new SqlCommand("sp_insertar_movimiento", cn, transaccion))
                            {
                                cmdBitacora.CommandType = CommandType.StoredProcedure;
                                cmdBitacora.Parameters.AddWithValue("@producto", nombreProd);
                                cmdBitacora.Parameters.AddWithValue("@tipo_movimiento", "SALIDA");
                                cmdBitacora.Parameters.AddWithValue("@cantidad", cant);
                                cmdBitacora.Parameters.AddWithValue("@usuario", "Cliente Público");
                                cmdBitacora.Parameters.AddWithValue("@proveedor", "Ticket #" + idVentaGenerada);
                                cmdBitacora.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        respuesta = "OK";
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        respuesta = "Error al procesar la venta: " + ex.Message;
                    }
                }
            }
            return respuesta;
        }
    }
}