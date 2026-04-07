using System;

namespace CapaDatos
{
    public static class Session
    {
        public static string UsuarioActual { get; set; }
        public static int LoginId { get; set; }

        public static int IdEmpleado { get; set; }
        public static string TipoAcceso { get; set; }
    }
}