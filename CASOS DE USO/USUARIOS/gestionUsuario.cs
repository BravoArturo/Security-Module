using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.USUARIOS
{
    public class gestionUsuario
    {
        public static MODELO.usuario obtenerUsuario(DATOS.PROYECTO oProyecto, Int32 CODIGO)
        {
            return oProyecto.USUARIOS.FirstOrDefault(c => c.id == CODIGO);
        }

        public static List<MODELO.usuario> obtenerUsuarios(DATOS.PROYECTO oProyecto, string NOMBRE)
        {
            var usuarios = from usuario in oProyecto.USUARIOS.Include("gruposUsuario")
                           where usuario.nombreUsuario.Contains(NOMBRE)
                           select usuario;
            return usuarios.ToList();
        }
    }
}
