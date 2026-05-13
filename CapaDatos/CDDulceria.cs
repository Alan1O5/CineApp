using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDDulceria
    {
        // Propiedades corregidas para coincidir con la base de datos
        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Codigo_Barras { get; set; }

        public DataTable Listar()
        {
            DataTable resultado = new DataTable("dulceria");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                // Usamos alias para que el DataGridView muestre nombres limpios
                string sql = "SELECT idproducto, nombre, tipo, precio, stock, codigo_barras FROM dulceria WHERE estado = 1";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                resultado = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public string Insertar(CDDulceria dulce)
        {
            string resul = ""; // Variable de control igual que en Editar
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_insertar_dulceria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", dulce.Nombre);
                cmd.Parameters.AddWithValue("@tipo", dulce.Tipo);
                cmd.Parameters.AddWithValue("@precio", dulce.Precio);
                cmd.Parameters.AddWithValue("@stock", dulce.Stock);
                cmd.Parameters.AddWithValue("@codigo_barras", dulce.Codigo_Barras);

                // Usamos la misma lógica que te funciona en Editar
                resul = cmd.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = "Error en SQL (Insertar): " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        public string Editar(CDDulceria dulce)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_editar_dulceria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idproducto", dulce.Idproducto);
                cmd.Parameters.AddWithValue("@nombre", dulce.Nombre);
                cmd.Parameters.AddWithValue("@tipo", dulce.Tipo);
                cmd.Parameters.AddWithValue("@precio", dulce.Precio);
                cmd.Parameters.AddWithValue("@stock", dulce.Stock);
                // CORRECCIÓN: Coincidencia con parámetro del SP
                cmd.Parameters.AddWithValue("@codigo_barras", dulce.Codigo_Barras);

                resul = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el registro";
            }
            catch (Exception ex)
            {
                resul = "Error en SQL (Editar): " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        public string Eliminar(CDDulceria dulce)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_eliminar_dulceria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", dulce.Idproducto);

                resul = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resul;
        }

        public string InsertarCompraCompleta(int idProducto, string nombreProducto, int cantidad, string proveedor, string usuario, decimal precioUnitario)
        {
            string respuesta = "";
            decimal totalCompra = cantidad * precioUnitario;

            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                cn.Open();
                using (SqlTransaction trans = cn.BeginTransaction())
                {
                    try
                    {
                        string queryCompra = @"INSERT INTO compras_dulceria (idempleado, proveedor, total) 
                                             VALUES (@idEmp, @prov, @tot); 
                                             SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdC = new SqlCommand(queryCompra, cn, trans);
                        cmdC.Parameters.AddWithValue("@idEmp", Session.IdEmpleado);
                        cmdC.Parameters.AddWithValue("@prov", proveedor);
                        cmdC.Parameters.AddWithValue("@tot", totalCompra);

                        int idCompraGenerada = Convert.ToInt32(cmdC.ExecuteScalar());

                        string queryDetalle = @"INSERT INTO detalle_compra_dulceria (idcompra, idproducto, cantidad, precio_compra) 
                                               VALUES (@idC, @idP, @cant, @prec)";

                        SqlCommand cmdD = new SqlCommand(queryDetalle, cn, trans);
                        cmdD.Parameters.AddWithValue("@idC", idCompraGenerada);
                        cmdD.Parameters.AddWithValue("@idP", idProducto);
                        cmdD.Parameters.AddWithValue("@cant", cantidad);
                        cmdD.Parameters.AddWithValue("@prec", precioUnitario);
                        cmdD.ExecuteNonQuery();

                        /* string queryStock = "UPDATE dulceria SET stock = stock + @cant WHERE idproducto = @idP";
                         SqlCommand cmdS = new SqlCommand(queryStock, cn, trans);
                         cmdS.Parameters.AddWithValue("@cant", cantidad);
                         cmdS.Parameters.AddWithValue("@idP", idProducto);
                         cmdS.ExecuteNonQuery();*/

                       
                        SqlCommand cmdB = new SqlCommand("sp_insertar_movimiento", cn, trans);
                        cmdB.CommandType = CommandType.StoredProcedure;
                        cmdB.Parameters.AddWithValue("@producto", nombreProducto); // <--- Esto asegura el nombre
                        cmdB.Parameters.AddWithValue("@tipo_movimiento", "ENTRADA");
                        cmdB.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdB.Parameters.AddWithValue("@usuario", usuario);
                        cmdB.Parameters.AddWithValue("@proveedor", "Ticket #" + idCompraGenerada);
                        cmdB.ExecuteNonQuery();

                        trans.Commit();
                        respuesta = "OK|" + idCompraGenerada;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        respuesta = "Error Transacción: " + ex.Message;
                    }
                }
            }
            return respuesta;
        }

        public int ObtenerIdPorCodigo(string codigo)
        {
            int id = 0;
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                // CORRECCIÓN: Nombre de columna correcto codigo_barras
                string query = "SELECT idproducto FROM dulceria WHERE codigo_barras = @cod";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@cod", codigo);
                cn.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado != null) id = Convert.ToInt32(resultado);
            }
            return id;
        }

        public DataTable ListarProveedores()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                string query = "SELECT idproveedor, nombre FROM Proveedor ORDER BY nombre ASC";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                // CORRECCIÓN: Nombre de columna codigo_barras
                string query = "SELECT idproducto, nombre, precio, stock FROM dulceria WHERE codigo_barras = @cod";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@cod", codigo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ListarProductosParaVenta()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                // Se agregan alias para que coincida con el dgvProductos del formulario
                string query = "SELECT idproducto, nombre as Producto, precio as Precio, stock as Stock FROM dulceria WHERE stock > 0";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public string ActualizarStock(int idproducto, int nuevoStock)
        {
            string rpta = "";
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    cn.Open();
                    string query = "UPDATE dulceria SET stock = @stock WHERE idproducto = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@stock", nuevoStock);
                    cmd.Parameters.AddWithValue("@id", idproducto);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el stock";
                }
                catch (Exception ex) { rpta = ex.Message; }
            }
            return rpta;
        }

        public string ActualizarPrecio(int idproducto, decimal nuevoPrecio)
        {
            string rpta = "";
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    cn.Open();
                    string query = "UPDATE dulceria SET precio = @precio WHERE idproducto = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@precio", nuevoPrecio);
                    cmd.Parameters.AddWithValue("@id", idproducto);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el precio";
                }
                catch (Exception ex) { rpta = ex.Message; }
            }
            return rpta;
        }

        public string InsertarMovimiento(string producto, string tipo, int cantidad, string usuario, string proveedor)
        {
            string rpta = "";
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("sp_insertar_movimiento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@producto", producto);
                    // CORRECCIÓN: Parámetro @tipo_movimiento (image_2d8edf.png)
                    cmd.Parameters.AddWithValue("@tipo_movimiento", tipo);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@proveedor", proveedor);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar el movimiento";
                }
                catch (Exception ex) { rpta = ex.Message; }
            }
            return rpta;
        }

        public DataTable ListarMovimientos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                string query = @"SELECT idmovimiento, producto, tipo_movimiento AS Movimiento, 
                         cantidad, fecha, usuario, proveedor AS Proveedor 
                         FROM MovimientosDulceria ORDER BY fecha DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerCabeceraCompra(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    // Nota: Aquí usamos 'fechacompra' para evitar el error de 'Invalid column name fecha'
                    string query = @"SELECT 
                                idcompra AS folio, 
                                fechacompra, 
                                proveedor, 
                                total,
                                (SELECT nombre FROM Empleado WHERE idempleado = c.idempleado) AS empleado
                             FROM compras_dulceria c 
                             WHERE idcompra = @id";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // Esto te dirá si el error persiste en otra columna
                    throw new Exception("Error en SQL (Cabecera): " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable ObtenerDetalleCompra(int id)   
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                string query = "SELECT * FROM detalle_compra_dulceria WHERE idcompra = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerCabeceraVenta(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    // En ventas no hay proveedor, así que enviamos un texto vacío o "CLIENTE"
                    string query = @"SELECT 
                                idventa AS folio, 
                                fechaventa AS fechacompra, 
                                'CLIENTE FINAL' AS proveedor, 
                                total,
                                (SELECT nombre FROM Empleado WHERE idempleado = v.idempleado) AS empleado
                             FROM ventas_dulceria v 
                             WHERE idventa = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex) { throw new Exception("Error al consultar venta: " + ex.Message); }
            }
            return dt;
        }

        public DataTable ObtenerDetalleVenta(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    // Seleccionamos las columnas calculadas de la base de datos
                    string query = @"SELECT 
                                d.idproducto, 
                                p.nombre AS Producto, 
                                d.cantidad, 
                                d.precio_unitario AS precio, 
                                d.iva, 
                                d.subtotal
                             FROM detalle_venta_dulceria d
                             INNER JOIN dulceria p ON d.idproducto = p.idproducto
                             WHERE d.idventa = @id";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex) { throw ex; }
            }
            return dt;
        }
        public string InsertarConBitacora(CDDulceria dulce, string proveedor, string usuario, decimal precioCompra)
        {
            string resul = "";
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                conexion.Open();
                // Iniciamos una transacción: si algo falla, todo se cancela (Rollback)
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // PASO 1: Insertar el producto en la tabla 'dulceria'
                    SqlCommand cmdProd = new SqlCommand("sp_insertar_dulceria", conexion, transaccion);
                    cmdProd.CommandType = CommandType.StoredProcedure;
                    cmdProd.Parameters.AddWithValue("@nombre", dulce.Nombre);
                    cmdProd.Parameters.AddWithValue("@tipo", dulce.Tipo);
                    cmdProd.Parameters.AddWithValue("@precio", dulce.Precio); // Precio Venta
                    cmdProd.Parameters.AddWithValue("@stock", dulce.Stock);
                    cmdProd.Parameters.AddWithValue("@codigo_barras", dulce.Codigo_Barras);

                    // Ejecutamos y verificamos
                    int filasProd = cmdProd.ExecuteNonQuery();

                    if (filasProd >= 1)
                    {
                        // PASO 2: Registrar el movimiento en la bitácora
                        // Usamos el SP que ya tienes para movimientos
                        SqlCommand cmdMov = new SqlCommand("sp_insertar_movimiento", conexion, transaccion);
                        cmdMov.CommandType = CommandType.StoredProcedure;
                        cmdMov.Parameters.AddWithValue("@producto", dulce.Nombre);
                        cmdMov.Parameters.AddWithValue("@tipo_movimiento", "ENTRADA");
                        cmdMov.Parameters.AddWithValue("@cantidad", dulce.Stock);
                        cmdMov.Parameters.AddWithValue("@usuario", usuario);
                        cmdMov.Parameters.AddWithValue("@proveedor", proveedor);

                        cmdMov.ExecuteNonQuery();

                        // PASO 3: Si todo salió bien, confirmamos los cambios en la BD
                        transaccion.Commit();
                        resul = "OK";
                    }
                    else
                    {
                        transaccion.Rollback();
                        resul = "Error: No se pudo crear el producto base.";
                    }
                }
                catch (Exception ex)
                {
                    // Si hay CUALQUIER error, deshacemos todo
                    transaccion.Rollback();
                    resul = "Error en Transacción: " + ex.Message;
                }
            }
            return resul;
        }
        public string RegistrarNuevoProductoMaestro(string nombre, string tipo, decimal pVenta, int stock, string codigo, string prov, string user, decimal pCompra)
        {
            string resul = "Error: No se pudo establecer conexión con el servidor.";
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    conexion.Open();
                    using (SqlTransaction trans = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insertar en tabla dulceria (Referencia: image_205cd7.png)
                            using (SqlCommand cmdP = new SqlCommand("sp_insertar_dulceria", conexion, trans))
                            {
                                cmdP.CommandType = CommandType.StoredProcedure;
                                cmdP.Parameters.AddWithValue("@nombre", nombre);
                                cmdP.Parameters.AddWithValue("@tipo", tipo);
                                cmdP.Parameters.AddWithValue("@precio", pVenta);
                                cmdP.Parameters.AddWithValue("@stock", stock);
                                cmdP.Parameters.AddWithValue("@codigo_barras", codigo);
                                cmdP.ExecuteNonQuery();
                            }

                            // 2. Insertar en bitácora de movimientos (Referencia: image_206451.png)
                            using (SqlCommand cmdM = new SqlCommand("sp_insertar_movimiento", conexion, trans))
                            {
                                cmdM.CommandType = CommandType.StoredProcedure;
                                cmdM.Parameters.AddWithValue("@producto", nombre);
                                cmdM.Parameters.AddWithValue("@tipo_movimiento", "ENTRADA");
                                cmdM.Parameters.AddWithValue("@cantidad", stock);
                                cmdM.Parameters.AddWithValue("@usuario", user);
                                cmdM.Parameters.AddWithValue("@proveedor", prov);
                                cmdM.ExecuteNonQuery();
                            }

                            trans.Commit();
                            resul = "OK";
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            resul = "Fallo en SQL: " + ex.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    resul = "Fallo de Conexión: " + ex.Message;
                }
            }
            return resul;
        }

        public int InsertarYObtenerID(CDDulceria dulce)
        {
            int idGenerado = 0;
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                conexion.Open();
                // Insertamos con el stock real (@stock)
                string sql = @"INSERT INTO dulceria (nombre, tipo, precio, stock, codigo_barras) 
                       VALUES (@nombre, @tipo, @precio, @stock, @codigo); 
                       SELECT CAST(SCOPE_IDENTITY() as int);";

                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", dulce.Nombre);
                cmd.Parameters.AddWithValue("@tipo", dulce.Tipo);
                cmd.Parameters.AddWithValue("@precio", dulce.Precio);
                cmd.Parameters.AddWithValue("@stock", dulce.Stock); // El valor que viene del txt
                cmd.Parameters.AddWithValue("@codigo", dulce.Codigo_Barras);

                idGenerado = (int)cmd.ExecuteScalar();
            }
            return idGenerado;
        }

        public string EliminarLogico(int idproducto)
        {
            string rpta = "";
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    cn.Open();
                    // Cambiamos el DELETE por un UPDATE
                    string sql = "UPDATE dulceria SET estado = 0 WHERE idproducto = @id";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", idproducto);

                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el producto";
                }
                catch (Exception ex)
                {
                    rpta = "Error en SQL (Eliminar): " + ex.Message;
                }
            }
            return rpta;
        }
    }
}