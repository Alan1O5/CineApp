using System.Data.SqlClient;
using System.Data;

public class Conexion
{
    public static string Conn =
        "Data Source=DESKTOP-BLR6VSO;Initial Catalog=cinedb;Integrated Security=true";

    private SqlConnection conexion;

    public Conexion()
    {
        conexion = new SqlConnection(Conn);
    }

    public SqlConnection AbrirConexion()
    {
        if (conexion.State == ConnectionState.Closed)
            conexion.Open();

        return conexion;
    }

    public void CerrarConexion()
    {
        if (conexion.State == ConnectionState.Open)
            conexion.Close();
    }
}
