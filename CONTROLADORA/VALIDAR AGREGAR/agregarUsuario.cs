using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA.VALIDAR_AGREGAR
{
    public class agregarUsuario : ConnectionToSql
    {
        public bool agregarU(string nombreUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from dbo.usuarios where nombreUsuario= @nombreUsuario";
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            estaticosAgregar.agregarU = reader.GetString(1);
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