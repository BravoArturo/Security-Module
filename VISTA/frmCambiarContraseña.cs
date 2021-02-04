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

namespace VISTA
{
    public partial class frmCambiarContraseña : MetroFramework.Forms.MetroForm
    {
        private static frmCambiarContraseña instancia;
        public static frmCambiarContraseña obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmCambiarContraseña();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmCambiarContraseña();
            }
            return instancia;
        }
        CONTROLADORA.cUSUARIOS usuarios;
        MODELO.usuario oUsuario;
        string clave = MODELO.crypPassword.cryp.Decrypt(loginCache.claveUsuario, true);
        public frmCambiarContraseña()
        {
            InitializeComponent();
            usuarios = CONTROLADORA.cUSUARIOS.obtenerInstancia();
            oUsuario = usuarios.obtenerUsuario(loginCache.id);

        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNuevaClave.Text == clave)
            {
                MessageBox.Show("Ingrese una clave distinta a la existente");
                return;
            }
            if (txtNuevaClave.Text != txtRepetirNuevaClave.Text)
            {
                MessageBox.Show("Las claves no coinciden");
                return;
            }
            oUsuario.claveUsuario = MODELO.crypPassword.cryp.Encrypt(txtNuevaClave.Text, true);
            usuarios.modificarUsuario(oUsuario);
            MessageBox.Show("Clave cambiada con exito");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
