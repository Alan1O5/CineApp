using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDPeliculas
    {
        public int Idpelicula { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }

        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resultado = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand cmd = new SqlCommand("sp_ListarPeliculas", conexion);
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
        public string Insertar(CDPeliculas peli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_InsertarPelicula", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@nombre", peli.Nombre);
                Cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                Cmd.Parameters.AddWithValue("@clasificacion", peli.Clasificacion);
                Cmd.Parameters.AddWithValue("@genero", peli.Genero);
                Cmd.Parameters.AddWithValue("@idioma", peli.Idioma);

                SqlParameter resultado = new SqlParameter("@resultado", SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(resultado);

                Cmd.ExecuteNonQuery();
                resul = resultado.Value.ToString() == "1" ? "OK" : "La película ya existe";
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
        public string Editar(CDPeliculas peli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_EditarPelicula", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idpelicula", peli.Idpelicula);
                Cmd.Parameters.AddWithValue("@nombre", peli.Nombre);
                Cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                Cmd.Parameters.AddWithValue("@clasificacion", peli.Clasificacion);
                Cmd.Parameters.AddWithValue("@genero", peli.Genero);
                Cmd.Parameters.AddWithValue("@idioma", peli.Idioma);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el registro";
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
        public string Eliminar(CDPeliculas peli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_EliminarPelicula", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idpelicula", peli.Idpelicula);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
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
        public DataTable BuscarNombre(CDPeliculas peli)
        {
            DataTable resul = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_BuscarPeliculaPorNombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@nombre", peli.Buscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resul;
        }
        public DataTable BuscarGenero(CDPeliculas peli)
        {
            DataTable resul = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_BuscarPeliculaPorGenero", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@genero", peli.Buscar);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }

            return resul;
        }
        public DataTable BuscarDuracion(CDPeliculas peli)
        {
            DataTable resul = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_BuscarPeliculaPorDuracion", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@duracion", peli.Buscar);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }

            return resul;
        }
        public DataTable BuscarClasificacion(CDPeliculas peli)
        {
            DataTable resul = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_BuscarPeliculaPorClasificacion", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@clasificacion", peli.Buscar);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }

            return resul;
        }
        public DataTable BuscarIdioma(CDPeliculas peli)
        {
            DataTable resul = new DataTable("peliculas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_BuscarPeliculaPorIdioma", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idioma", peli.Buscar);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }

            return resul;
        }

        public DataTable MostrarEdiciones()
        {
            DataTable resul = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarBitacoraModificacionPeliculas", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resul);
            }

            return resul;
        }

        public DataTable MostrarEliminaciones()
        {
            DataTable resul = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarBitacoraEliminacionPeliculas", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resul);
            }

            return resul;
        }
        public DataTable MostrarBitacora()
        {
            DataTable resul = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                accion,
                idpelicula,
                campo_modificado AS detalle,
                CAST(valor_anterior AS NVARCHAR(200)) AS valor_anterior,
                CAST(valor_nuevo AS NVARCHAR(200)) AS valor_nuevo,
                usuario_modifico AS usuario,
                fecha_modificacion AS fecha
            FROM Bitacora_Modificacion_Peliculas

            UNION ALL

            SELECT 
                accion,
                idpelicula,
                nombre,
                CAST('' AS NVARCHAR(200)),
                CAST('' AS NVARCHAR(200)),
                usuario_elimino,
                fecha_eliminacion
            FROM Bitacora_Peliculas

            ORDER BY fecha DESC
        ", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resul);
            }

            return resul;
        }


    }
}