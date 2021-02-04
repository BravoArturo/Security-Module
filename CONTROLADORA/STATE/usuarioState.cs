using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.STATE
{
    
    public abstract class usuarioState
    {
        public abstract string estado();
        public string mensaje { get; set; }
    }
    public class usuarioActivo : usuarioState
    {
        public override string estado()
        {
           return mensaje = "Bienvenido señor/a " + loginCache.nombreUsuario;
        }
    }
    public class usuarioInactivo : usuarioState
    {
        public override string estado()
        {
           return mensaje = "Usted se encuentra momentáneamente inactivo por favor hable con su administrador";
        }
    }
}
