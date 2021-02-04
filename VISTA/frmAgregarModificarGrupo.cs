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
    public partial class frmAgregarModificarGrupo : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cGRUPOS grupos;
        CONTROLADORA.cUSUARIOS usuarios;
        MODELO.grupo oGrupo;
        string accion;
        public frmAgregarModificarGrupo(MODELO.grupo miGrupo, string miAccion)
        {
            InitializeComponent();
            usuarios = CONTROLADORA.cUSUARIOS.obtenerInstancia();
            grupos = CONTROLADORA.cGRUPOS.obtenerInstancia();
            oGrupo = miGrupo;
            accion = miAccion;

            if (accion != "A")
            {
                txtNombreGrupo.Text = oGrupo.nombreGrupo;
                txtNombreGrupo.Enabled = false;
                if (oGrupo.permisoAgregar == "SI")
                {
                    cbAgregar.Checked = true;
                }else
                {
                    cbAgregar.Checked = false;
                }
                if (oGrupo.permisoModificar == "SI")
                {
                    cbModificar.Checked = true;
                }else
                {
                    cbModificar.Checked = false;
                }
                if (oGrupo.permisoEliminar == "SI")
                {
                    cbEliminar.Checked = true;
                }else
                {
                    cbEliminar.Checked = false;
                }
            }
        }

        private void frmAgregarModificarGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreGrupo.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de grupo");
                return;
            }
            if (cbAgregar.Checked == false && cbModificar.Checked == false && cbEliminar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar al menos un permiso");
                return;
            }

            if (accion == "A")
            {
                usuarioModel usuario = new usuarioModel();
                var validarAlta = usuario.agregarG(txtNombreGrupo.Text);
                if (validarAlta == true)
                {
                    MessageBox.Show("Ya existe un grupo con el mismo nombre");
                    return;
                }

                oGrupo = new MODELO.grupo();
            }
            oGrupo.nombreGrupo = txtNombreGrupo.Text;
            if (cbAgregar.Checked == true)
            {
                oGrupo.permisoAgregar = "SI";
            }else
            {
                oGrupo.permisoAgregar = "NO";
            }
            if (cbModificar.Checked == true)
            {
                oGrupo.permisoModificar = "SI";
            }else
            {
                oGrupo.permisoModificar = "NO";
            }
            if (cbEliminar.Checked == true)
            {
                oGrupo.permisoEliminar = "SI";
            }else
            {
                oGrupo.permisoEliminar = "NO";
            }

            if (accion == "A")
            {
                grupos.agregarGrupo(oGrupo);
                informeCache.haagregadoG = "SI";
                informeCache.hsagregarG = Convert.ToString(DateTime.Now);
            }
            else if (accion == "M")
            {
                grupos.modificarGrupo(oGrupo);
                informeCache.hamodificadoG = "SI";
            }
            this.DialogResult = DialogResult.OK;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestionarGrupos frmGestionarGrupos = frmGestionarGrupos.obtenerInstancia();
            frmGestionarGrupos.Show();
            this.Hide();
        }
    }
}
