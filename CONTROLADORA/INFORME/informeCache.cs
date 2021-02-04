using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA.INFORME
{
    public static class informeCache
    {
        public static string nombre { get; set; }
        public static string nombreUsuario { get; set; }
        public static DateTime login { get; set; }
        public static DateTime logout { get; set; }
        public static string haagregadoU { get; set; }
        public static string hamodificadoU { get; set; }
        public static string haeliminadoU { get; set; }
        public static string haagregadoG { get; set; }
        public static string hamodificadoG { get; set; }
        public static string haeliminadoG { get; set; }
        public static double tiempoSesion { get; set; }
        public static string filtro { get; set; }

        public static string cbAU { get; set; }
        public static string cbMU { get; set; }
        public static string cbEU { get; set; }
        public static string cbAG { get; set; }
        public static string cbMG { get; set; }
        public static string cbEG { get; set; }
        public static DataTable tablaEstatica { get; set; }

        public static string hsagregoU { get; set; }
        public static string hseliminarU { get; set; }
        public static string hsagregarG { get; set; }
        public static string hseliminarG { get; set; }
        public static string reseteoclave { get; set; }
    }
}
