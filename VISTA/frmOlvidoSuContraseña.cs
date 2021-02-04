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
using CONTROLADORA.PASSWORD;

namespace VISTA
{
    public partial class frmOlvidoSuContraseña : MetroFramework.Forms.MetroForm
    {
        private static frmOlvidoSuContraseña instancia;
        public static frmOlvidoSuContraseña obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmOlvidoSuContraseña();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmOlvidoSuContraseña();
            }
            return instancia;
        }
        public frmOlvidoSuContraseña()
        {
            InitializeComponent();
        }

        private void frmOlvidoSuContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            recuperarOlvidar.recuperar = "SI";
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtCorreoUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un correo electronico");
                return;
            }
            usuarioModel recover = new usuarioModel();
            var recoverPassword = recover.recover(txtNombreUsuario.Text, txtCorreoUsuario.Text);
            MessageBox.Show(recoverPassword);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
