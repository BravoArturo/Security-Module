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
    public partial class frmGestionarGrupos : MetroFramework.Forms.MetroForm
    {
        MODELO.grupo oGrupo;
        private static frmGestionarGrupos instancia;
        public static frmGestionarGrupos obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmGestionarGrupos();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmGestionarGrupos();
            }
            return instancia;
        }
        CONTROLADORA.cGRUPOS grupos;
        public frmGestionarGrupos()
        {
            InitializeComponent();
            grupos = CONTROLADORA.cGRUPOS.obtenerInstancia();
            armaGrilla();
            dgvGrupos.Columns[1].HeaderText = "Nombre de grupo";
            dgvGrupos.Columns[2].HeaderText = "Agregar";
            dgvGrupos.Columns[3].HeaderText = "Modificar";
            dgvGrupos.Columns[4].HeaderText = "Eliminar";
        }
        public void armaGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = grupos.listarGrupos(txtBuscarGrupo.Text).ToList();
        }
        private void frmGestionarGrupos_Load(object sender, EventArgs e)
        {
            //aca manejo con el cache.
        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtBuscarGrupo.Text))
        //    {
        //        dgvUsuariosGrupo.DataSource = null;
        //    }
        //    usuarioModel usuarioModel = new usuarioModel();
        //    var leerGrupo = usuarioModel.leerGrupo(txtBuscarGrupo.Text);
        //    if (leerGrupo == true)
        //    {
        //        var enviarDatos = usuarioModel.enviarDatos(loginCache.idGrupoUsuarios);
        //        dgvUsuariosGrupo.DataSource = enviarDatos;
        //        armaGrilla();
        //    }
        //    if (leerGrupo == false)
        //    {
        //        MessageBox.Show("Ingrese un usuario correcto");
        //        dgvUsuariosGrupo.DataSource = null;
        //        txtBuscarGrupo.Text = "";
        //        armaGrilla();
        //        return;
        //    }

        //}

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            try {
                if (dgvGrupos.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un grupo de la lista");
                    return;
                }
                MODELO.grupo oGrupo = grupos.obtenerGrupo(Convert.ToInt32(dgvGrupos.CurrentRow.Cells[0].Value));
                DialogResult consulta = MessageBox.Show("¿Desea elimar el grupo " + oGrupo.nombreGrupo +"?", "ELIMINAR", MessageBoxButtons.YesNo);
                if (consulta == DialogResult.Yes)
                {
                    grupos.eliminarGrupo(oGrupo);
                    armaGrilla();
                    informeCache.haeliminadoG = "SI";
                    informeCache.hseliminarU = Convert.ToString(DateTime.Now);
                }
            }
            catch
            {
                MessageBox.Show("Si hay usuarios pertenecientes al grupo no se puede eliminar");
                return;
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista");
                return;
            }
            oGrupo = (MODELO.grupo)dgvGrupos.CurrentRow.DataBoundItem;
            frmAgregarModificarGrupo frmAgregarModificarGrupo = new VISTA.frmAgregarModificarGrupo(oGrupo, "M");
            DialogResult resultado = frmAgregarModificarGrupo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                armaGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarModificarGrupo frmAgregarModificarGrupo = new VISTA.frmAgregarModificarGrupo(oGrupo, "A");
            DialogResult resultado = frmAgregarModificarGrupo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                armaGrilla();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu frmMenu = frmMenu.obtenerInstancia();
            frmMenu.Show();
            this.Hide();
        }

        private void txtBuscarGrupo_TextChanged(object sender, EventArgs e)
        {
            usuarioModel usuarioModel = new usuarioModel();
            var leerGrupo = usuarioModel.leerGrupo(txtBuscarGrupo.Text);
            if (leerGrupo == true)
            {
                var enviarDatos = usuarioModel.enviarDatos(loginCache.idGrupoUsuarios);
                dgvUsuariosGrupo.DataSource = enviarDatos;
                armaGrilla();
                dgvUsuariosGrupo.Columns[1].HeaderText = "Nombre de usuario";
                dgvUsuariosGrupo.Columns[2].HeaderText = "Nombre";
                dgvUsuariosGrupo.Columns[3].HeaderText = "Apellido";
                dgvUsuariosGrupo.Columns[4].HeaderText = "Email";
                dgvUsuariosGrupo.Columns[5].HeaderText = "Clave";
                dgvUsuariosGrupo.Columns[6].HeaderText = "Grupo al que pertenece";
                dgvUsuariosGrupo.Columns[7].HeaderText = "Estado";
                dgvUsuariosGrupo.Columns[8].HeaderText = "Tipo";
                dgvUsuariosGrupo.Columns[9].HeaderText = "ID";
                dgvUsuariosGrupo.Columns[10].HeaderText = "Nombre de grupo";
                dgvUsuariosGrupo.Columns[11].HeaderText = "Permiso de agregar";
                dgvUsuariosGrupo.Columns[12].HeaderText = "Permiso de modificar";
                dgvUsuariosGrupo.Columns[13].HeaderText = "Permiso de eliminar";
            }
            if (string.IsNullOrEmpty(txtBuscarGrupo.Text))
            {
                armaGrilla();
                dgvUsuariosGrupo.DataSource = null;
            }
        }
    }
}
