using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA.VALIDAR_AGREGAR
{
    public class validarGrupo:ConnectionToSql
    {
        public bool agregarG(string nombreGrupo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from dbo.grupoes where nombreGrupo= @nombreGrupo";
                    command.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            estaticosAgregar.agregarG = reader.GetString(1);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
