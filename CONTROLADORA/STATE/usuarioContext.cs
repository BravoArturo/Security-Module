using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.STATE
{
    public class usuarioContext
    {
        private usuarioState state;
        public usuarioState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public void estado()
        {
            state.estado();
        }
    }
}
