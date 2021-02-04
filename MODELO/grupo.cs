using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class grupo
    {
        public Int32 id { get; set; }
        public string nombreGrupo { get; set; }
        public string permisoAgregar { get; set; }
        public string permisoEliminar { get; set; }
        public string permisoModificar { get; set; }
        public override string ToString()
        {
            return nombreGrupo;
        }
    }
}
