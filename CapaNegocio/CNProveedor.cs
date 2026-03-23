using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProveedor
    {
        public static DataTable Listar()
        {
            CDProveedor Datos = new CDProveedor();
            return Datos.Listar();
        }

        public static string Guardar(string nombre, string tipo_producto, string telefono, string razonsocial, string rfc)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Nombre = nombre;
            Datos.Tipo_producto = tipo_producto;
            Datos.Telefono = telefono;
            Datos.Razonsocial = razonsocial;
            Datos.Rfc = rfc;

            return Datos.Insertar(Datos);
        }

        public static string Editar(int idproveedor, string nombre, string tipo_producto, string telefono, string razonsocial, string rfc)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Idproveedor = idproveedor;
            Datos.Nombre = nombre;
            Datos.Tipo_producto = tipo_producto;
            Datos.Telefono = telefono;
            Datos.Razonsocial = razonsocial;
            Datos.Rfc = rfc;

            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproveedor)
        {
            CDProveedor Datos = new CDProveedor();
            return Datos.Eliminar(idproveedor);
        }

        // Puente para las alertas de stock
        public static DataTable GenerarAlertas(int limiteStock = 10)
        {
            CDProveedor Datos = new CDProveedor();
            return Datos.ObtenerAlertasStock(limiteStock);
        }
    }
}