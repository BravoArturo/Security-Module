using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class cUSUARIOS
    {
        private static cUSUARIOS instancia;
        public static cUSUARIOS obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new cUSUARIOS();
            }
            return instancia;
        }
        DATOS.PROYECTO oProyecto;
        public cUSUARIOS()
        {
            oProyecto = new DATOS.PROYECTO();
        }
       public List<MODELO.usuario> listarUsuarios(string NOMBRE)
        {
            return CASOS_DE_USO.USUARIOS.gestionUsuario.obtenerUsuarios(oProyecto, NOMBRE);
        }
        public MODELO.usuario obtenerUsuario(Int32 CODIGO)
        {
            return CASOS_DE_USO.USUARIOS.gestionUsuario.obtenerUsuario(oProyecto, CODIGO);
        }
        public void agregarUsuario(MODELO.usuario oUsuario)
        {
            CASOS_DE_USO.USUARIOS.operacionUsuario.agregarUsuario(oProyecto, oUsuario);
            oProyecto.SaveChanges();
        }
        public void modificarUsuario(MODELO.usuario oUsuario)
        {
            CASOS_DE_USO.USUARIOS.operacionUsuario.modificarUsuario(oProyecto, oUsuario);
            oProyecto.SaveChanges();
        }
        public void eliminarUsuario(MODELO.usuario oUsuario)
        {
            CASOS_DE_USO.USUARIOS.operacionUsuario.eliminarUsuario(oProyecto, oUsuario);
            oProyecto.SaveChanges();
        }
        public List<MODELO.grupo> obtenerGrupos()
        {
            return CASOS_DE_USO.GRUPOS.gestionGrupo.obtenerGrupos(oProyecto, String.Empty);
        }
        static public bool ValidacionEMAIL(EventArgs e, string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }
        }
    }
}
