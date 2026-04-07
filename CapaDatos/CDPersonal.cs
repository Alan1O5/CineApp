using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDPersonal
    {
        public int Idusuario { get; set; }
        public int Idempleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Acceso { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }

        public DataTable Listar()
        {
            DataTable dt = new DataTable("personal");
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("splistar_personal_integral", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public string Guardar(CDPersonal obj)
        {
            string res = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("spguardar_personal_integral", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                    cmd.Parameters.AddWithValue("@pass", obj.Password);
                    cmd.Parameters.AddWithValue("@acceso", obj.Acceso);
                    cmd.Parameters.AddWithValue("@estado", obj.Estado);

                    cmd.ExecuteNonQuery();
                    res = "OK";
                }
            }
            catch (Exception ex) { res = ex.Message; }
            return res;
        }

        public string Editar(CDPersonal obj)
        {
            string res = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("speditar_personal_integral", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idusuario", obj.Idusuario);
                    cmd.Parameters.AddWithValue("@idempleado", obj.Idempleado);
                    cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                    cmd.Parameters.AddWithValue("@pass", obj.Password);
                    cmd.Parameters.AddWithValue("@acceso", obj.Acceso);
                    cmd.Parameters.AddWithValue("@estado", obj.Estado);

                    cmd.ExecuteNonQuery();
                    res = "OK";
                }
            }
            catch (Exception ex) { res = ex.Message; }
            return res;
        }

        public string Eliminar(int idusuario, int idempleado)
        {
            string res = "";
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("speliminar_usuario_integral", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.Parameters.AddWithValue("@idempleado", idempleado);

                    cmd.ExecuteNonQuery();
                    res = "OK";
                }
            }
            catch (Exception ex) { res = ex.Message; }
            return res;
        }

        public DataTable BuscarNombre(string buscar)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("spbuscar_personal_nombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", buscar);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarUsuario(string buscar)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("spbuscar_personal_usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", buscar);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}