using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.INFORME
{
    public class gestionInforme
    {
        public static MODELO.informe obtenerInforme(DATOS.PROYECTO oProyecto, Int32 CODIGO)
        {
            return oProyecto.INFORMES.FirstOrDefault(c => c.id == CODIGO);
        }

        public static List<MODELO.informe> obtenerInformes(DATOS.PROYECTO oProyecto, string NOMBRE)
        {
            var informes = from informe in oProyecto.INFORMES
                         where informe.nombre.Contains(NOMBRE)
                         select informe;
            return informes.ToList();
        }
    }
}
