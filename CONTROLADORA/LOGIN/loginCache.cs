using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
    public static class loginCache
    {
        //DATOS USUARIO
        public static Int32 id { get; set; }
        public static string nombreUsuario { get; set; }
        public static string nombre { get; set; }
        public static string apellidoUsuario { get; set; }
        public static string emailUsuario { get; set; }
        public static string claveUsuario { get; set; }
        public static int gruposUsuario { get; set; }
        public static string estado { get; set; }
        public static string tipoUsuario { get; set; }
        //DATOS GRUPO
        public static string nombreGrupo { get; set; }
        public static string permisoAgregar { get; set; }
        public static string permisoEliminar { get; set; }
        public static string permisoModificar { get; set; }

        //PARA GRILLA USUARIOS EN GRUPO
        public static string nombreGrupoUsuarios { get; set; }
        public static int idGrupoUsuarios { get; set; }

    }
}
