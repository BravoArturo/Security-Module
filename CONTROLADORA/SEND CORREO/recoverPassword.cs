using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CONTROLADORA.SEND_CORREO;
using CONTROLADORA.PASSWORD;

namespace CONTROLADORA.SEND_CORREO
{
    public class recoverPassword: ConnectionToSql
    {
        public string recover(string userRequesting, string mailRequesting)
        {
            string p;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (recuperarOlvidar.recuperar == "SI")
                    {
                        command.CommandText = "select *from dbo.usuarios where nombreUsuario=@usuario and emailUsuario=@mail";
                        command.Parameters.AddWithValue("@usuario", userRequesting);
                        command.Parameters.AddWithValue("@mail", mailRequesting);
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read() == true)
                        {
                            string nombreUSuario = reader.GetString(1);
                            string emailUsuario = reader.GetString(4);
                            string claveUsuario = reader.GetString(5);

                            var mailService = new SEND_CORREO.systemSupportMail();
                            mailService.sendMail(
                                subject: "Solicitud de recuperar contraseña",
                                body: "Hola " + nombreUSuario + " tu contraseña actual es " + MODELO.crypPassword.cryp.Decrypt(claveUsuario, true) +
                                " por favor una vez que ingreses al sistema cambiala por motivos de seguridad",
                                recipientMail: new List<string> { emailUsuario }
                                );
                            recuperarOlvidar.devolucion = "Hola " + nombreUSuario + " por favor verifica tu correo ha sido enviada tu contraseña";
                        }
                        else
                        {
                            recuperarOlvidar.devolucion = "No se encuentra el usuario o correo electronico";
                        }
                    }
                    if (recuperarOlvidar.recuperar == "NO")
                    {
                        command.CommandText = "select *from dbo.usuarios where nombreUsuario=@usuario and emailUsuario=@mail";
                        command.Parameters.AddWithValue("@usuario", userRequesting);
                        command.Parameters.AddWithValue("@mail", mailRequesting);
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read() == true)
                        {
                            string nombreUSuario = reader.GetString(1);
                            string emailUsuario = reader.GetString(4);
                            string claveUsuario = recuperarOlvidar.claveGenerada;

                            var mailService = new SEND_CORREO.systemSupportMail();
                            mailService.sendMail(
                                subject: "Solicitud de recuperar contraseña",
                                body: "Hola " + nombreUSuario + " tu contraseña nueva contraseña generada es " + MODELO.crypPassword.cryp.Decrypt(claveUsuario, true) +
                                " por favor una vez que ingreses al sistema cambiala por motivos de seguridad",
                                recipientMail: new List<string> { emailUsuario }
                                );
                            recuperarOlvidar.devolucion = "Contraseña del usuario " + nombreUSuario + " generada";
                        }
                        else
                        {
                            recuperarOlvidar.devolucion = "No se ha podido generar la clave";
                        }
                    }


                }

            }
            return p = recuperarOlvidar.devolucion;
        }
    }
}
