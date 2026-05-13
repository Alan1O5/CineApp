using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNDulceria
    {
        // --- CONSULTAS ---
        public static DataTable Listar() => new CDDulceria().Listar();

        public static DataTable BuscarPorCodigo(string codigo) => new CDDulceria().BuscarPorCodigo(codigo);

        public static DataTable ListarProductosParaVenta() => new CDDulceria().ListarProductosParaVenta();

        public static DataTable ListarProveedores() => new CDDulceria().ListarProveedores();

        public static int ObtenerIdPorCodigo(string codigo) => new CDDulceria().ObtenerIdPorCodigo(codigo);

        // --- MANTENIMIENTO (CRUD) ---
        public static string Guardar(string nombre, string tipo, decimal precio, int stock, string codigo_barras)
        {
            CDDulceria Datos = new CDDulceria
            {
                Nombre = nombre,
                Tipo = tipo,
                Precio = precio,
                Stock = stock,
                Codigo_Barras = codigo_barras
            };

            string respuesta = Datos.Insertar(Datos);

            // Si la respuesta es nula, algo muy grave pasa en la instancia
            if (respuesta == null) return "ERROR_FATAL: La capa de datos devolvió NULL.";

            return respuesta;
        }

        public static string Editar(int id, string nombre, string tipo, decimal precio, int stock, string codigo)
        {
            CDDulceria Datos = new CDDulceria
            {
                Idproducto = id,
                Nombre = nombre,
                Tipo = tipo,
                Precio = precio,
                Stock = stock,
                Codigo_Barras = codigo
            };
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproducto)
        {
            // Ahora llama al nuevo método de borrado lógico
            return new CDDulceria().EliminarLogico(idproducto);
        }

        // --- PROCESOS DE COMPRA Y STOCK ---
        public static string InsertarCompraCompleta(int idProducto, string nombreProducto, int cantidad, string proveedor, string usuario, decimal precioUnitario)
        {
            // Llama a la transacción completa que maneja cabecera, detalle, stock y bitácora
            return new CDDulceria().InsertarCompraCompleta(idProducto, nombreProducto, cantidad, proveedor, usuario, precioUnitario);
        }

        public static string ActualizarStock(int idproducto, int nuevoStock)
        {
            return new CDDulceria().ActualizarStock(idproducto, nuevoStock);
        }

        // --- LÓGICA DE PRECIOS DINÁMICOS ---
        public static void ActualizarPreciosPorVenta(int idProductoVendido)
        {
            CDDulceria cd = new CDDulceria();
            DataTable tabla = cd.Listar();

            if (tabla == null) return;

            foreach (DataRow row in tabla.Rows)
            {
                int id = Convert.ToInt32(row["idproducto"]);
                decimal precio = Convert.ToDecimal(row["precio"]);
                decimal nuevoPrecio;

                if (id == idProductoVendido)
                {
                    nuevoPrecio = precio * 1.10m; // Sube 10%
                }
                else
                {
                    decimal descuento = precio * 0.10m;
                    if (descuento > 1) descuento = 1;
                    nuevoPrecio = precio - descuento;
                    if (nuevoPrecio < 0) nuevoPrecio = 0;
                }

                nuevoPrecio = Math.Round(nuevoPrecio, 2);
                cd.ActualizarPrecio(id, nuevoPrecio);
            }
        }

        // --- SOLUCIONES PARA FORMULARIOS (BITÁCORA Y REGISTROS) ---

        public static DataTable ListarMovimientos() => new CDDulceria().ListarMovimientos();

        public static void RegistrarMovimiento(string producto, string tipoMovimiento, int cantidad, string usuario, string proveedor)
        {
            // Sincronizado con el parámetro @tipo_movimiento del SP
            new CDDulceria().InsertarMovimiento(producto, tipoMovimiento, cantidad, usuario, proveedor);
        }

        public static string ProcesarEntradaMercancia(int idP, string nomP, int cant, string prov, string user, decimal precio)
        {
            return InsertarCompraCompleta(idP, nomP, cant, prov, user, precio);
        }

        public static DataTable ObtenerCabeceraCompra(int id) => new CDDulceria().ObtenerCabeceraCompra(id);

        public static DataTable ObtenerDetalleCompra(int id) => new CDDulceria().ObtenerDetalleCompra(id);

        // Método puente para obtener la cabecera de una venta
        public static DataTable ObtenerCabeceraVenta(int id)
        {
            return new CDDulceria().ObtenerCabeceraVenta(id);
        }

        // Método puente para obtener el detalle de una venta
        public static DataTable ObtenerDetalleVenta(int id)
        {
            return new CDDulceria().ObtenerDetalleVenta(id);
        }

        public static string RegistrarNuevoProductoMaestro(string nombre, string tipo, decimal pVenta, int stock, string codigo, string prov, string user, decimal pCompra)
        {
            CDDulceria obj = new CDDulceria();
            // Es vital que el resultado de la Capa de Datos se devuelva a la Presentación
            return obj.RegistrarNuevoProductoMaestro(nombre, tipo, pVenta, stock, codigo, prov, user, pCompra);
        }

        public static int RegistrarBaseYObtenerID(string nombre, string tipo, decimal precio, int stock, string codigo)
        {
            CDDulceria datos = new CDDulceria
            {
                Nombre = nombre,
                Tipo = tipo,
                Precio = precio,
                Stock = stock, // Agregado
                Codigo_Barras = codigo
            };
            return new CDDulceria().InsertarYObtenerID(datos);
        }

    }
}