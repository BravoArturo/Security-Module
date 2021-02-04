using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.USUARIOS
{
    public class operacionUsuario
    {
        public static void agregarUsuario(DATOS.PROYECTO oProyecto, MODELO.usuario oUsuario)
        {
            oProyecto.USUARIOS.Add(oUsuario);
        }
        public static void eliminarUsuario(DATOS.PROYECTO oProyecto, MODELO.usuario oUsuario)
        {
            oProyecto.USUARIOS.Remove(oUsuario);
        }
        public static void modificarUsuario(DATOS.PROYECTO oProyecto, MODELO.usuario oUsuario)
        {
            oProyecto.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
