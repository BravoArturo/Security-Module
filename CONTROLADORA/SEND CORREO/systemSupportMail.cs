using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.SEND_CORREO
{
    class systemSupportMail: masterMailServer
    {
        public systemSupportMail()
        {
            senderMail = "finaldetrabajodecampo@gmail.com";
            password = "arturomatiaslautaro";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtoClient();
        }
    }
}
