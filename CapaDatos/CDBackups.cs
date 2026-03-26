using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDBackup
    {
        private string nombreBD = "cinedb"; 

        public string GenerarBackup(string rutaDestino)
        {
            string resp = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    
                    string query = $"BACKUP DATABASE [{nombreBD}] TO DISK = '{rutaDestino}' WITH FORMAT, MEDIANAME = 'CineBackup', NAME = 'Respaldo Mensual';";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    resp = "OK";
                }
            }
            catch (Exception ex)
            {
                resp = "Error al respaldar: " + ex.Message;
            }
            return resp;
        }

        public string RestaurarBackup(string rutaOrigen)
        {
            string resp = "";
            try
            {
                
                string stringConexionMaster = Conexion.Conn.Replace(nombreBD, "master");

                using (SqlConnection cn = new SqlConnection(stringConexionMaster))
                {
                    cn.Open();

                    
                    string queryCerrar = $"ALTER DATABASE [{nombreBD}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (SqlCommand cmd = new SqlCommand(queryCerrar, cn)) { cmd.ExecuteNonQuery(); }

                    
                    string queryRestaurar = $"RESTORE DATABASE [{nombreBD}] FROM DISK = '{rutaOrigen}' WITH REPLACE;";
                    using (SqlCommand cmd = new SqlCommand(queryRestaurar, cn)) { cmd.ExecuteNonQuery(); }

                    
                    string queryAbrir = $"ALTER DATABASE [{nombreBD}] SET MULTI_USER;";
                    using (SqlCommand cmd = new SqlCommand(queryAbrir, cn)) { cmd.ExecuteNonQuery(); }

                    resp = "OK";
                }
            }
            catch (Exception ex)
            {
                resp = "Error al restaurar: " + ex.Message;
            }
            return resp;
        }
        public DataTable ListarHistorial()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_listar_historial_respaldos", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el historial de respaldos: " + ex.Message);
            }
            return dt;
        }
        public bool ExisteRespaldoEsteMes()
        {
            bool existe = false;
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_verificar_respaldo_mes", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        if (cantidad > 0) existe = true;
                    }
                }
            }
            catch {  }
            return existe;
        }

        public void RegistrarHistorial(string nombreArchivo, string usuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    string query = "INSERT INTO HistorialRespaldos (archivo, usuario) VALUES (@archivo, @usuario)";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@archivo", nombreArchivo);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch {  }
        }
    }
}