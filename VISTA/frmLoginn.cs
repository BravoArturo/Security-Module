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
using CONTROLADORA.STATE;
using CONTROLADORA.INFORME;

namespace VISTA
{
    public partial class frmLoginn : MetroFramework.Forms.MetroForm
    {
        public frmLoginn()
        {
            InitializeComponent();
            informeCache.hsagregoU = "NO";
            informeCache.hseliminarU = "NO";
            informeCache.hsagregarG = "NO";
            informeCache.hseliminarG = "NO";
            informeCache.reseteoclave = "NO";
        }

        private void logOut(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar una clave");
                return;
            }
            usuarioModel usuario = new usuarioModel();
            var validarLogin = usuario.loginUsuario(txtUsuario.Text, MODELO.crypPassword.cryp.Encrypt(txtPassword.Text, true));
            if (validarLogin == true)
            {
                usuarioContext oUsuarioContext = new usuarioContext();
                if (loginCache.estado == "ACTIVO")
                {
                    //AQUI SE IMPLEMENTA EL PATRON STATE (ESTADO ACTIVO)
                    oUsuarioContext.State = new usuarioActivo();
                    oUsuarioContext.estado();
                    frmMenu frmMenu = frmMenu.obtenerInstancia();
                    frmMenu.Show();
                    frmMenu.FormClosed += logOut;
                    this.Hide();
                    MessageBox.Show(oUsuarioContext.State.mensaje);
                    informeCache.login = DateTime.Now;
                }
                else if (loginCache.estado == "INACTIVO")
                {
                    //AQUI SE IMPLEMENTA EL PATRON STATE (ESTADO INACTIVO)
                    oUsuarioContext.State = new usuarioInactivo();
                    oUsuarioContext.estado();
                    MessageBox.Show(oUsuarioContext.State.mensaje);
                }

            }
            if (validarLogin == false)
            {
                MessageBox.Show("El usuario o contraseña no coinciden");
                return;
            }
        }

        private void fPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOlvidoSuContraseña frmOlvidoSuContraseña = frmOlvidoSuContraseña.obtenerInstancia();
            frmOlvidoSuContraseña.ShowDialog();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este trabajo ha sido realizado por: Arturo Bravo, Garello Lautaro y Matias Moneghessi");
        }

        private void frmLoginn_Load(object sender, EventArgs e)
        {

        }
    }
}
