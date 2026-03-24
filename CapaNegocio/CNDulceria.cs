using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNDulceria
    {
        public static DataTable Listar()
        {
            CDDulceria Datos = new CDDulceria();
            return Datos.Listar();
        }

        public static string Guardar(string nombre, string tipo, decimal precio, int stock, string codigoBarras)
        {
            CDDulceria Datos = new CDDulceria();
            Datos.Nombre = nombre;
            Datos.Tipo = tipo;
            Datos.Precio = precio;
            Datos.Stock = stock;
            Datos.CodigoBarras = codigoBarras; 

            return Datos.Insertar(Datos);
        }

        public static string Editar(int idproducto, string nombre, string tipo, decimal precio, int stock, string codigoBarras)
        {
            CDDulceria Datos = new CDDulceria();
            Datos.Idproducto = idproducto;
            Datos.Nombre = nombre;
            Datos.Tipo = tipo;
            Datos.Precio = precio;
            Datos.Stock = stock;

            Datos.CodigoBarras = codigoBarras;

            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproducto)
        {
            CDDulceria Datos = new CDDulceria();
            Datos.Idproducto = idproducto;

            return Datos.Eliminar(Datos);
        }

        public static void ActualizarPreciosPorVenta(int idProductoVendido)
        {
            CDDulceria cd = new CDDulceria();
            DataTable tabla = cd.Listar();

            foreach (DataRow row in tabla.Rows)
            {
                int id = Convert.ToInt32(row["idproducto"]);
                decimal precio = Convert.ToDecimal(row["precio"]);

                decimal nuevoPrecio;

                if (id == idProductoVendido)
                {
                    // El producto vendido sube 10%
                    nuevoPrecio = precio * 1.10m;
                }
                else
                {
                    // Los demás bajan 10%
                    decimal descuento = precio * 0.10m;

                    if (descuento > 1)
                        descuento = 1;

                    nuevoPrecio = precio - descuento;

                    if (nuevoPrecio < 0)
                        nuevoPrecio = 0;
                }

                nuevoPrecio = Math.Round(nuevoPrecio, 2);

                cd.ActualizarPrecio(id, nuevoPrecio);
            }
        }
        public static string ActualizarStock(int idproducto, int nuevoStock)
        {
            CDDulceria Datos = new CDDulceria();
            return Datos.ActualizarStock(idproducto, nuevoStock);
        }
        public static DataTable ListarMovimientos()
        {
            CDDulceria Datos = new CDDulceria();
            return Datos.ListarMovimientos();
        }

        public static void RegistrarMovimiento(string producto, string tipoMovimiento, int cantidad, string usuario, string proveedor)
        {
            CDDulceria Datos = new CDDulceria();
            Datos.InsertarMovimiento(producto, tipoMovimiento, cantidad, usuario, proveedor);
        }
        public static DataTable BuscarPorCodigo(string codigo)
        {
            CDDulceria Datos = new CDDulceria();
            return Datos.BuscarPorCodigo(codigo);
        }
        public static DataTable ListarProductosParaVenta()
        {
            CDDulceria Datos = new CDDulceria();
            return Datos.ListarProductosParaVenta();
        }
    }
}