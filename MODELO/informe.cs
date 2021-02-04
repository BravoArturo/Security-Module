using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class informe
    {
        public Int32 id { get; set; }
        public string nombre { get; set; }
        public DateTime login { get; set; }
        public DateTime logout { get; set; }
        public string haagregadoU { get; set; }
        public string hamodificadoU { get; set; }
        public string haeliminadoU { get; set; }
        public string haagregadoG { get; set; }
        public string hamodificadoG { get; set; }
        public string haeliminadoG { get; set; }
        //public double tiempoSesion { get; set; }
        public double tiempoSesion2 { get; set; }

        public string hsagregoU { get; set; }
        public string hseliminarU { get; set; }
        public string hsagregarG { get; set; }
        public string hseliminarG { get; set; }
        public string reseteoclave { get; set; }
    }
}
