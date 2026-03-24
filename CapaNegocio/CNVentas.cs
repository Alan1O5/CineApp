using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNVentas
    {
        public static string RealizarVenta(decimal total, int idEmpleado, DataTable carrito)
        {
            CDVentas Datos = new CDVentas();
            return Datos.ProcesarVenta(total, idEmpleado, carrito);
        }
        
    }
}