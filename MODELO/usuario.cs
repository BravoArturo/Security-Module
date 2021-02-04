using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class usuario
    {
        public Int32 id { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string claveUsuario { get; set; }
        public grupo gruposUsuario { get; set; }
        public string estado { get; set; }
        public string tipoUsuario { get; set; }

        public override string ToString()
        {
            return nombreUsuario;
        }     
        }
    }

