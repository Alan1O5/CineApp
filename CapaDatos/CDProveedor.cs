using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDProveedor
    {
        public int Idproveedor { get; set; }
        public string Nombre { get; set; }
        public string Tipo_producto { get; set; }
        public string Telefono { get; set; }
        public string Razonsocial { get; set; }
        public string Rfc { get; set; }

        public DataTable Listar()
        {
            DataTable resultado = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            using (SqlCommand cmd = new SqlCommand("sp_listar_proveedor", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(resultado);
                }
            }
            return resultado;
        }

        public string Insertar(CDProveedor prov)
        {
            string msj = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_insertar_proveedor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", prov.Nombre);
                    cmd.Parameters.AddWithValue("@tipo_producto", prov.Tipo_producto);
                    cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                    cmd.Parameters.AddWithValue("@razonsocial", prov.Razonsocial);
                    cmd.Parameters.AddWithValue("@rfc", prov.Rfc);

                    cn.Open();
                    msj = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el proveedor";
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
            return msj;
        }

        public string Editar(CDProveedor prov)
        {
            string msj = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_editar_proveedor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);
                    cmd.Parameters.AddWithValue("@nombre", prov.Nombre);
                    cmd.Parameters.AddWithValue("@tipo_producto", prov.Tipo_producto);
                    cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                    cmd.Parameters.AddWithValue("@razonsocial", prov.Razonsocial);
                    cmd.Parameters.AddWithValue("@rfc", prov.Rfc);

                    cn.Open();
                    msj = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el proveedor";
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
            return msj;
        }

        public string Eliminar(int idproveedor)
        {
            string msj = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_eliminar_proveedor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idproveedor", idproveedor);

                    cn.Open();
                    msj = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el proveedor";
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
            return msj;
        }

        // El método de alertas de stock adaptado al nuevo estilo
        public DataTable ObtenerAlertasStock(int limiteStock)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            using (SqlCommand cmd = new SqlCommand("sp_alertas_stock", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stock_minimo", limiteStock);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}