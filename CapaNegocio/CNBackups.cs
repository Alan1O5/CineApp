using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNBackup
    {
        public static string GenerarBackup(string ruta)
        {
            CDBackup cd = new CDBackup();
            return cd.GenerarBackup(ruta);
        }

        public static string RestaurarBackup(string ruta)
        {
            CDBackup cd = new CDBackup();
            return cd.RestaurarBackup(ruta);
        }
        public static DataTable ListarHistorial()
        {
            CDBackup cd = new CDBackup();
            return cd.ListarHistorial();
        }
        public static bool ExisteRespaldoEsteMes()
        {
            CDBackup cd = new CDBackup();
            return cd.ExisteRespaldoEsteMes();
        }

        public static void RegistrarHistorial(string nombreArchivo, string usuario)
        {
            CDBackup cd = new CDBackup();
            cd.RegistrarHistorial(nombreArchivo, usuario);
        }

        public static void EliminarRegistro(int idrespaldo)
        {
            CDBackup obj = new CDBackup();
            obj.EliminarRegistro(idrespaldo);
        }
    }
}