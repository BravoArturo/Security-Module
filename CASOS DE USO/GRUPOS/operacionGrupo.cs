using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.GRUPOS
{
    public class operacionGrupo
    {
        public static void agregarGrupo(DATOS.PROYECTO oProyecto, MODELO.grupo oGrupo)
        {
            oProyecto.GRUPOS.Add(oGrupo);
        }
        public static void eliminarGrupo(DATOS.PROYECTO oProyecto, MODELO.grupo oGrupo)
        {
            oProyecto.GRUPOS.Remove(oGrupo);
        }
        public static void modificarGrupo(DATOS.PROYECTO oProyecto, MODELO.grupo oGrupo)
        {
            oProyecto.Entry(oGrupo).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
