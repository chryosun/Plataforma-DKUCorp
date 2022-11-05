using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDKUCorp
{
    internal class Sesion
    {
        public static string nombreUsuario;
        public static char tipoUsuario;

        public static string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public static char TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public Sesion(string nombreUsuario,char tipousuario)
        {
            NombreUsuario = nombreUsuario;
            TipoUsuario = tipousuario;
        }

    }
}
