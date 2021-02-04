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
using CONTROLADORA.PASSWORD;
namespace VISTA
{
    public partial class frmGestionarUsuarios : MetroFramework.Forms.MetroForm
    {
        MODELO.usuario oUsuario;
        private static frmGestionarUsuarios instancia;
        public static frmGestionarUsuarios obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmGestionarUsuarios();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmGestionarUsuarios();
            }
            return instancia;
        }
        CONTROLADORA.cUSUARIOS usuarios;
        public frmGestionarUsuarios()
        {
            InitializeComponent();
            usuarios = CONTROLADORA.cUSUARIOS.obtenerInstancia();
            armaGrilla();
            dgvUsuarios.Columns[1].HeaderText = "Nombre de usuario";
            dgvUsuarios.Columns[2].HeaderText = "Nombre";
            dgvUsuarios.Columns[3].HeaderText = "Apellido";
            dgvUsuarios.Columns[4].HeaderText = "Email";
            dgvUsuarios.Columns[5].HeaderText = "Clave";
            dgvUsuarios.Columns[6].HeaderText = "Grupo al que pertenece";
            dgvUsuarios.Columns[7].HeaderText = "Estado";
            dgvUsuarios.Columns[8].HeaderText = "Tipo";
        }
        public void armaGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios.listarUsuarios(txtBuscar.Text).ToList();
        }
        private void frmGestionarUsuarios_Load(object sender, EventArgs e)
        {
            //aca manejo con el cache.
            usuarioModel usuario = new usuarioModel();
            var permiso = usuario.readGrupo(loginCache.gruposUsuario);
            if (permiso == true)
            {
                if (loginCache.permisoAgregar == "NO")
                {
                    btnAgregar.Enabled = false;
                }
                if (loginCache.permisoEliminar == "NO")
                {
                    btnELiminar.Enabled = false;
                }
                if (loginCache.permisoModificar == "NO")
                {
                    btnModificar.Enabled = false;
                }
                if (loginCache.tipoUsuario == "USUARIO")
                {
                    btnReset.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No se cargaron los permisos");
                return;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            armaGrilla();
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            MODELO.usuario oUsuario = usuarios.obtenerUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
            DialogResult consulta = MessageBox.Show("¿Desea elimar el usuario " + oUsuario.nombre + "?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (consulta == DialogResult.Yes)
            {
                usuarios.eliminarUsuario(oUsuario);
                armaGrilla();
                informeCache.haeliminadoG = "SI";
                informeCache.hseliminarG = Convert.ToString(DateTime.Now);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            oUsuario = (MODELO.usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            frmAgregarModificarUsuario frmAgregarModificarUsuario = new VISTA.frmAgregarModificarUsuario(oUsuario, "M");
            DialogResult resultado = frmAgregarModificarUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                armaGrilla();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarModificarUsuario frmAgregarModificarUsuario = new VISTA.frmAgregarModificarUsuario(oUsuario, "A");
            DialogResult resultado = frmAgregarModificarUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                armaGrilla();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            armaGrilla();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            recuperarOlvidar.recuperar = "NO";
            oUsuario = (MODELO.usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            char[] letters = "qwertyuiopasdfghjklñzxcvbnm0123456789*/+-.@".ToCharArray();
            Random r = new Random();
            string random = "";
            for (int i=0; i<10; i++)
            {
                random += letters[r.Next(0, 42)].ToString();
            }
             oUsuario.claveUsuario = MODELO.crypPassword.cryp.Encrypt(random, true);
             recuperarOlvidar.claveGenerada = oUsuario.claveUsuario;
             usuarios.modificarUsuario(oUsuario);
             informeCache.hamodificadoU = "SI";
            informeCache.reseteoclave = Convert.ToString(DateTime.Now);
             usuarioModel recover = new usuarioModel();
             var recoverPassword = recover.recover(oUsuario.nombreUsuario, oUsuario.emailUsuario);
             MessageBox.Show(recoverPassword);
             MessageBox.Show("La nueva contraseña a sido enviada al correo electronico del usuario");

        }

        private void lblAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu frmMenu = frmMenu.obtenerInstancia();
            frmMenu.Show();
            this.Hide();
        }
    }
}
