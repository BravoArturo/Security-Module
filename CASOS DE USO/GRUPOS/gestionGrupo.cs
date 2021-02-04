using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.GRUPOS
{
    public class gestionGrupo
    {
        public static MODELO.grupo obtenerGrupo(DATOS.PROYECTO oProyecto, Int32 CODIGO)
        {
            return oProyecto.GRUPOS.FirstOrDefault(c => c.id == CODIGO);
        }

        public static List<MODELO.grupo> obtenerGrupos(DATOS.PROYECTO oProyecto, string NOMBRE)
        {
            var grupos = from grupo in oProyecto.GRUPOS
                         where grupo.nombreGrupo.Contains(NOMBRE)
                         select grupo;
            return grupos.ToList();
        }
    }
}
