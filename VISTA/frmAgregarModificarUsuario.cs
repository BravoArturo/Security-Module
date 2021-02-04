using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA.INFORME;
using CONTROLADORA;

namespace VISTA
{
    public partial class frmAgregarModificarUsuario : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cUSUARIOS usuarios;
        CONTROLADORA.cGRUPOS grupos;
        MODELO.usuario oUsuario;
        string accion;
        public frmAgregarModificarUsuario(MODELO.usuario miUsuario, string miAccion)
        {
            InitializeComponent();
            usuarios = CONTROLADORA.cUSUARIOS.obtenerInstancia();
            grupos = CONTROLADORA.cGRUPOS.obtenerInstancia();
            oUsuario = miUsuario;
            accion = miAccion;
            cmbGrupos.DataSource = usuarios.obtenerGrupos();
            cmbGrupos.SelectedItem = "nombreGrupo";

            if (accion != "A")
            {
                txtNombreUsuario.Enabled = false;
                txtClave.Enabled = false;
                txtRepetirClave.Enabled = false;
                txtNombreUsuario.Text = oUsuario.nombreUsuario;
                txtNombre.Text = oUsuario.nombre;
                txtApellido.Text = oUsuario.apellidoUsuario;
                txtEmailUsuario.Text = oUsuario.emailUsuario;
                txtClave.Text = "*****";
                txtRepetirClave.Text = "*****";
                cmbGrupos.SelectedItem = oUsuario.gruposUsuario;
            }

        }

        private void frmAgregarModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtEmailUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave");
                return;
            }
            if (txtClave.Text != txtRepetirClave.Text)
            {
                MessageBox.Show("Las claves no coinciden");
                return;
            }
            if (ckActivo.Checked == false && ckInactivo.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un estado");
                return;
            }
            if (ckAdministrador.Checked == false && ckUsuario.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario");
                return;
            }
            if (cmbGrupos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            CONTROLADORA.cUSUARIOS.ValidacionEMAIL(e, txtEmailUsuario.Text);
            if (accion == "A")
            {
                oUsuario = new MODELO.usuario();
                oUsuario.nombreUsuario = txtNombreUsuario.Text;
                oUsuario.nombre = txtNombre.Text;
                oUsuario.apellidoUsuario = txtApellido.Text;
                oUsuario.emailUsuario = txtEmailUsuario.Text;
                oUsuario.claveUsuario = MODELO.crypPassword.cryp.Encrypt(txtClave.Text, true);
                oUsuario.gruposUsuario = ((MODELO.grupo)cmbGrupos.SelectedItem);
            }
            /*oUsuario.nombreUsuario = txtNombreUsuario.Text;
            oUsuario.nombre = txtNombre.Text;
            oUsuario.apellidoUsuario = txtApellido.Text;
            oUsuario.emailUsuario = txtEmailUsuario.Text;
            oUsuario.claveUsuario = MODELO.crypPassword.cryp.Encrypt(txtClave.Text, true);
            oUsuario.gruposUsuario = ((MODELO.grupo)cmbGrupos.SelectedItem);*/
            if (ckAdministrador.Checked == true)
            {
                oUsuario.tipoUsuario = "ADMINISTRADOR";
            }
            else{
                oUsuario.tipoUsuario = "USUARIO";
            }
            if (ckActivo.Checked == true)
            {
                oUsuario.estado = "ACTIVO";
            }
            else{
                oUsuario.estado = "INACTIVO";
            }
            if (accion == "A")
            {
                usuarioModel usuario = new usuarioModel();
                var validarAlta = usuario.agregarU(txtNombreUsuario.Text);
                if (validarAlta == true)
                {
                    MessageBox.Show("Ya existe un usuario con el mismo nombre");
                    return;
                }
                usuarios.agregarUsuario(oUsuario);
                informeCache.haagregadoU = "SI";
                informeCache.hsagregoU = Convert.ToString(DateTime.Now);
            }
            else if (accion == "M")
            {
                usuarios.modificarUsuario(oUsuario);
                oUsuario.nombreUsuario = txtNombreUsuario.Text;
                oUsuario.nombre = txtNombre.Text;
                oUsuario.apellidoUsuario = txtApellido.Text;
                oUsuario.emailUsuario = txtEmailUsuario.Text;
                oUsuario.gruposUsuario = ((MODELO.grupo)cmbGrupos.SelectedItem);
                informeCache.hamodificadoU = "SI";
            }
            this.DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestionarUsuarios frmGestionarUsuarios = frmGestionarUsuarios.obtenerInstancia();
            frmGestionarUsuarios.Show();
            this.Hide();
        }
    }
}
