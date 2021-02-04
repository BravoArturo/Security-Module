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
using System.Data.SqlClient;

namespace VISTA
{
    public partial class frmMisDatos : MetroFramework.Forms.MetroForm
    {
        private static frmMisDatos instancia;
        public static frmMisDatos obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmMisDatos();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmMisDatos();
            }
            return instancia;
        }
        public frmMisDatos()
        {
            InitializeComponent();
        }

        private void frmMisDatos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            lblNombreCompleto.Text = "Nombre completo: " + loginCache.apellidoUsuario + " " + loginCache.nombre;
            lblNombreUsuario.Text = "Nombre usuario: " + loginCache.nombreUsuario;
            lblEmail.Text = "Email: " + loginCache.emailUsuario;
            usuarioModel usuario = new usuarioModel();
            //cargo metodo para leer grupo del cache.
            var showinfogrupo = usuario.readGrupo(loginCache.gruposUsuario);
            if (showinfogrupo == true)
            {
                lblGrupo.Text = loginCache.nombreGrupo;
            }
            else
            {
                MessageBox.Show("no se cargaron los grupos");
                return;
            }
            lblGrupo.Text = "Grupo al que pertenece: " + loginCache.nombreGrupo;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            frmCambiarContraseña frmCambiarContraseña = frmCambiarContraseña.obtenerInstancia();
            frmCambiarContraseña.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblGrupo_Click(object sender, EventArgs e)
        {

        }

        private void lblAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu frmMenu = frmMenu.obtenerInstancia();
            frmMenu.Show();
            this.Hide();
        }
    }
}
