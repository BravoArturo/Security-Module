using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA
{
    public class readGrupo : ConnectionToSql
    {
        //metodo de subir el grupo al cache.
        public bool leerGrupo(int idGrupo)
        {
                using (var connection2 = GetConnection())
                {
                    connection2.Open();
                    using (var command2 = new SqlCommand())
                    {
                        command2.Connection = connection2;
                        command2.CommandText = "select *from dbo.grupoes where id=@id";
                        command2.Parameters.AddWithValue("@id", idGrupo);
                        command2.CommandType = CommandType.Text;
                        SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            loginCache.nombreGrupo = reader2.GetString(1);
                            loginCache.permisoAgregar = reader2.GetString(2);
                            loginCache.permisoEliminar = reader2.GetString(3);
                            loginCache.permisoModificar = reader2.GetString(4);
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



