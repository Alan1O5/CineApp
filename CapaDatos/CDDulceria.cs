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
        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public string CodigoBarras { get; set; }

        public DataTable Listar()
        {
            DataTable resultado = new DataTable("dulceria");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand cmd = new SqlCommand("sp_listar_dulceria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

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
            string resul = "";
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
                cmd.Parameters.AddWithValue("@codigo_barras", dulce.CodigoBarras);

                // NUEVO PARÁMETRO: Se envía la imagen o DBNull si está vacía
                

                resul = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
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

                // AQUÍ AGREGAS LA LÍNEA PARA EL CÓDIGO
                cmd.Parameters.AddWithValue("@codigo_barras", dulce.CodigoBarras);

                resul = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
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

        public string ActualizarPrecio(int idproducto, decimal precio)
        {
            string resp = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_actualizar_precio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idproducto", idproducto);
                cmd.Parameters.AddWithValue("@precio", precio);

                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resp;
        }

        public string ActualizarStock(int idproducto, int stock)
        {
            string resp = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_actualizar_stock", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idproducto", idproducto);
                cmd.Parameters.AddWithValue("@stock", stock);

                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resp;
        }
        public DataTable ListarMovimientos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_listar_movimientos", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar movimientos: " + ex.Message);
            }
            return tabla;
        }

        public void InsertarMovimiento(string producto, string tipoMovimiento, int cantidad)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_insertar_movimiento", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@producto", producto);
                    cmd.Parameters.AddWithValue("@tipo_movimiento", tipoMovimiento);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar en bitácora: " + ex.Message);
            }
        }
    }
}