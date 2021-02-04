using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CONTROLADORA
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionstring;
        public ConnectionToSql()
        {
            connectionstring = @"data source=DESKTOP-8T1OVBM;initial catalog=DATOS.PROYECTO;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
