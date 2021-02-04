using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA.USUARIOS_DE_GRUPO
{
    public class readNombreGrupo:ConnectionToSql
    {
        public bool leerGrupo(string nombreGrupo)
        {
            using (var connection2 = GetConnection())
            {
                connection2.Open();
                using (var command2 = new SqlCommand())
                {
                    command2.Connection = connection2;
                    command2.CommandText = "select *from dbo.grupoes where nombreGrupo=@nombreGrupo";
                    command2.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                    command2.CommandType = CommandType.Text;
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            loginCache.idGrupoUsuarios = reader2.GetInt32(0);
                            loginCache.nombreGrupoUsuarios = reader2.GetString(1);
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
