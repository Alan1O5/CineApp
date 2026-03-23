using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   
        public class CDUsuarios
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Contrasena { get; set; }

            public DataTable Login(CDUsuarios user)
            {
                DataTable resultado = new DataTable();
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_LoginUsuario", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", user.Correo);
                    cmd.Parameters.AddWithValue("@contrasena", user.Contrasena);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(resultado);
                }
                return resultado;
            }

            public int RegistrarLogin(string usuario)
            {
                int loginId = 0;
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_registrar_login", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    SqlParameter outputId = new SqlParameter("@newId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    loginId = Convert.ToInt32(outputId.Value);
                }
                return loginId;
            }

            public void RegistrarLogout(int loginId)
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlCommand cmd = new SqlCommand("sp_logout_por_id", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", loginId);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public DataTable InformeTiempoConexion()
            {
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                using (SqlDataAdapter da = new SqlDataAdapter("sp_informe_tiempo_conexion", cn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
                return dt;
            }
        }
}
