using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Session
    {
        public static string UsuarioActual { get; set; }
        public static int LoginId { get; set; }
        public static int IdEmpleado { get; set; }
    }
}
