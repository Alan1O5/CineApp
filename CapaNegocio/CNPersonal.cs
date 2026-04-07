using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNPersonal
    {
        public static DataTable Listar()
        {
            return new CDPersonal().Listar();
        }

        public static string Guardar(string nombre, string apellidos, string direccion, string telefono, string usuario, string password, string acceso, string estado)
        {
            CDPersonal obj = new CDPersonal();
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Usuario = usuario;
            obj.Password = password;
            obj.Acceso = acceso;
            obj.Estado = estado;

            return obj.Guardar(obj);
        }

        public static string Editar(int idusuario, int idempleado, string nombre, string apellidos, string direccion, string telefono, string usuario, string password, string acceso, string estado)
        {
            CDPersonal obj = new CDPersonal();
            obj.Idusuario = idusuario;
            obj.Idempleado = idempleado;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Usuario = usuario;
            obj.Password = password;
            obj.Acceso = acceso;
            obj.Estado = estado;

            return obj.Editar(obj);
        }

        public static string Eliminar(int idusuario, int idempleado)
        {
            return new CDPersonal().Eliminar(idusuario, idempleado);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        {
            return new CDPersonal().BuscarNombre(textoBuscar);
        }

        public static DataTable BuscarUsuario(string textoBuscar)
        {
            return new CDPersonal().BuscarUsuario(textoBuscar);
        }
    }
}