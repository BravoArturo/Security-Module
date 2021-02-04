using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;
using CONTROLADORA.INFORME;
using VISTA.INFORME;
using MetroFramework.Forms;

namespace VISTA
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        private static frmMenu instancia;
        public static frmMenu obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmMenu();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmMenu();
            }
            return instancia;
        }
        CONTROLADORA.cINFORME informes;
        MODELO.informe oInforme = new MODELO.informe();
        public frmMenu()
        {
            InitializeComponent();
            informes = CONTROLADORA.cINFORME.obtenerInstancia();
            informeCache.haagregadoU = "NO";
            informeCache.hamodificadoU = "NO";
            informeCache.haeliminadoU = "NO";
            informeCache.haagregadoG = "NO";
            informeCache.hamodificadoG = "NO";
            informeCache.haeliminadoG = "NO";
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionarUsuarios frmGestionarUsuarios = frmGestionarUsuarios.obtenerInstancia();
            frmGestionarUsuarios.ShowDialog();
            //this.Hide();
        }

        private void btnGestionarGrupos_Click(object sender, EventArgs e)
        {
            if (loginCache.tipoUsuario == "ADMINISTRADOR")
            {
                frmGestionarGrupos frmGestionarGrupos = frmGestionarGrupos.obtenerInstancia();
                frmGestionarGrupos.ShowDialog();
                //this.Hide();
            }
            else{
                MessageBox.Show("Solo los administradores puede gestionar grupos");
                return;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "LOGOUT", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Usted sigue en el programa");
                return;
            }
            else
                informeCache.logout = DateTime.Now;
            informeCache.tiempoSesion = (informeCache.logout - informeCache.login).TotalHours;
            MessageBox.Show("su tiempo de sesion fue "+informeCache.tiempoSesion+ " horas");

            oInforme.nombre = loginCache.nombreUsuario;
            oInforme.haagregadoU = informeCache.haagregadoU;
            oInforme.hamodificadoU = informeCache.hamodificadoU;
            oInforme.haeliminadoU = informeCache.haeliminadoU;
            oInforme.haagregadoG = informeCache.haagregadoG;
            oInforme.hamodificadoG = informeCache.hamodificadoG;
            oInforme.haeliminadoG = informeCache.haeliminadoG;
            oInforme.login = informeCache.login;
            oInforme.logout = informeCache.logout;
            oInforme.tiempoSesion2 = informeCache.tiempoSesion;
            oInforme.hsagregoU = informeCache.hsagregoU;
            oInforme.hseliminarU = informeCache.hseliminarU;
            oInforme.hsagregarG = informeCache.hsagregarG;
            oInforme.hseliminarG = informeCache.hseliminarG;
            oInforme.reseteoclave = informeCache.reseteoclave;

            informes.agregarInforme(oInforme);
            
            this.Close();
        }

    

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInforme frmInforme = frmInforme.obtenerInstancia();
            frmInforme.ShowDialog();
            //this.Hide();
        }

        private void btnMisDatos_Click(object sender, EventArgs e)
        {
            frmMisDatos frmMisDatos = frmMisDatos.obtenerInstancia();
            frmMisDatos.ShowDialog();
            //this.Hide();
        }
    }
}
