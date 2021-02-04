using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA
{
    public class checkLogin: ConnectionToSql
    {
        public bool login(string nombreUsuario, string claveUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from dbo.usuarios where nombreUsuario= @nombreUsuario and claveUsuario=@claveUsuario";
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@claveUsuario", claveUsuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            loginCache.id = reader.GetInt32(0);
                            loginCache.nombreUsuario = reader.GetString(1);
                            loginCache.nombre = reader.GetString(2);
                            loginCache.apellidoUsuario = reader.GetString(3);
                            loginCache.emailUsuario = reader.GetString(4);
                            loginCache.claveUsuario = reader.GetString(5);
                            loginCache.estado = reader.GetString(6);
                            loginCache.tipoUsuario = reader.GetString(7);
                            loginCache.gruposUsuario = reader.GetInt32(8);                            
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
