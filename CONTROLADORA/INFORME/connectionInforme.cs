using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA.INFORME
{
    public class connectionInforme : ConnectionToSql
    {
        public DataTable obtenerInforme(string nombreUsuario, string AU, string MU, string EU, string AG, string MG, string EG, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (informeCache.filtro == "NO")
                    {
                        command.CommandText = "select *from dbo.informes";
                    }
                    else if (informeCache.filtro == "SI")
                    {
                        command.CommandText = "select *from dbo.informes where nombre=@nombreUsuario and haagregadoU=@AU and hamodificadoU=@MU and haeliminadoU=@EU and haagregadoG=@AG and hamodificadoG=@MG and haeliminadoG=@EG and login between @fechaInicio and @fechaFin";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@AU", AU);
                        command.Parameters.AddWithValue("@MU", MU);
                        command.Parameters.AddWithValue("@EU", EU);
                        command.Parameters.AddWithValue("@AG", AG);
                        command.Parameters.AddWithValue("@MG", MG);
                        command.Parameters.AddWithValue("@EG", EG);
                        command.Parameters.AddWithValue("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                        command.Parameters.AddWithValue("@fechaFin", SqlDbType.Date).Value = fechaFin;
                    }

                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }
    }
}
    


            
        
    

