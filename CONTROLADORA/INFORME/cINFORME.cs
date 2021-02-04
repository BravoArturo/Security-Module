using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cINFORME
    {
        private static cINFORME instancia;
        public static cINFORME obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new cINFORME();
            }
            return instancia;
        }
        DATOS.PROYECTO oProyecto;
        public cINFORME()
        {
            oProyecto = new DATOS.PROYECTO();
        }
        public List<MODELO.informe> listarInformes(string NOMBRE)
        {
            return CASOS_DE_USO.INFORME.gestionInforme.obtenerInformes(oProyecto, NOMBRE);
        }
        public MODELO.informe obtenerInforme(Int32 CODIGO)
        {
            return CASOS_DE_USO.INFORME.gestionInforme.obtenerInforme(oProyecto, CODIGO);
        }
        public void agregarInforme(MODELO.informe oInforme)
        {
            CASOS_DE_USO.INFORME.operacionInforme.agregarInforme(oProyecto, oInforme);
            oProyecto.SaveChanges();
        }
        public List<MODELO.usuario> obtenerUsuarios()
        {
            return CASOS_DE_USO.USUARIOS.gestionUsuario.obtenerUsuarios(oProyecto, String.Empty);
        }
        public List<MODELO.grupo> obtenerGrupos()
        {
            return CASOS_DE_USO.GRUPOS.gestionGrupo.obtenerGrupos(oProyecto, String.Empty);
        }
    }
}
