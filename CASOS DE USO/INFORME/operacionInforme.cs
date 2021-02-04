using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.INFORME
{
    public class operacionInforme
    {
        public static void agregarInforme(DATOS.PROYECTO oProyecto, MODELO.informe oInforme)
        {
            oProyecto.INFORMES.Add(oInforme);
        }
    }
}
