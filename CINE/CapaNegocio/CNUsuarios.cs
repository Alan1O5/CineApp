using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUsuarios
    {
        public static DataTable Login(string correo, string contrasena)
        {
            CDUsuarios datos = new CDUsuarios
            {
                Correo = correo,
                Contrasena = contrasena
            };
            return datos.Login(datos);
        }

        public static int RegistrarLogin(string usuario)
        {
            CDUsuarios datos = new CDUsuarios();
            return datos.RegistrarLogin(usuario);
        }

        public static void RegistrarLogout(int loginId)
        {
            CDUsuarios datos = new CDUsuarios();
            datos.RegistrarLogout(loginId);
        }

        public static DataTable MostrarInformeTiempo()
        {
            CDUsuarios datos = new CDUsuarios();
            return datos.InformeTiempoConexion();
        }

    }
}
