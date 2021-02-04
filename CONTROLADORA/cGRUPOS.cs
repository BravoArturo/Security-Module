using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cGRUPOS
    {
        private static cGRUPOS instancia;
        public static cGRUPOS obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new cGRUPOS();
            }
            return instancia;
        }
        DATOS.PROYECTO oProyecto;
        public cGRUPOS()
        {
            oProyecto = new DATOS.PROYECTO();
        }
        public List<MODELO.grupo> listarGrupos(string NOMBRE)
        {
            return CASOS_DE_USO.GRUPOS.gestionGrupo.obtenerGrupos(oProyecto, NOMBRE);
        }
        public MODELO.grupo obtenerGrupo(Int32 CODIGO)
        {
            return CASOS_DE_USO.GRUPOS.gestionGrupo.obtenerGrupo(oProyecto, CODIGO);
        }
        public void agregarGrupo(MODELO.grupo oGrupo)
        {
            CASOS_DE_USO.GRUPOS.operacionGrupo.agregarGrupo(oProyecto, oGrupo);
            oProyecto.SaveChanges();
        }
        public void modificarGrupo(MODELO.grupo oGrupo)
        {
            CASOS_DE_USO.GRUPOS.operacionGrupo.modificarGrupo(oProyecto, oGrupo);
            oProyecto.SaveChanges();
        }
        public void eliminarGrupo(MODELO.grupo oGrupo)
        {
            CASOS_DE_USO.GRUPOS.operacionGrupo.eliminarGrupo(oProyecto, oGrupo);
            oProyecto.SaveChanges();
        }
        public List<MODELO.usuario> obtenerUsuarios()
        {
            return CASOS_DE_USO.USUARIOS.gestionUsuario.obtenerUsuarios(oProyecto, String.Empty);
        }
    }
}
