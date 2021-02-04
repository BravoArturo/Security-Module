using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CONTROLADORA.USUARIOS_DE_GRUPO
{
    public class usuariosDeGrupo : ConnectionToSql
    {
        public DataTable enviarDato(int idGrupo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from dbo.usuarios join dbo.grupoes on dbo.usuarios.gruposUsuario_id = @idGrupo";
                    command.Parameters.AddWithValue("@idGrupo", idGrupo);
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
