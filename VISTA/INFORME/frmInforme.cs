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
using SpreadsheetLight;
using System.Data.SqlClient;



namespace VISTA.INFORME
{
    public partial class frmInforme : MetroFramework.Forms.MetroForm
    {
        private static frmInforme instancia;
        public static frmInforme obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmInforme();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmInforme();
            }
            return instancia;
        }
        
        usuarioModel informe = new usuarioModel();
        public frmInforme()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            informeCache.filtro = "NO";

            informeCache.cbAU = "NO";
            informeCache.cbMU = "NO";
            informeCache.cbEU = "NO";
            informeCache.cbAG = "NO";
            informeCache.cbMG = "NO";
            informeCache.cbEG = "NO";

            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now;

            var tabla = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);
            dgvInforme.DataSource = tabla;
            informeCache.tablaEstatica = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);

            dgvInforme.Columns[1].HeaderText = "Nombre de usuario";
            dgvInforme.Columns[2].HeaderText = "Horario de Login";
            dgvInforme.Columns[3].HeaderText = "Hoario de LogOut";
            dgvInforme.Columns[4].HeaderText = "Agregó usuario?";
            dgvInforme.Columns[5].HeaderText = "Modificó usuario?";
            dgvInforme.Columns[6].HeaderText = "Eliminó usuario?";
            dgvInforme.Columns[7].HeaderText = "Agregó grupo?";
            dgvInforme.Columns[8].HeaderText = "Modificó grupo?";
            dgvInforme.Columns[9].HeaderText = "Eliminó grupo?";
            dgvInforme.Columns[10].HeaderText = "Tiempo de sesión (en horas)";
            dgvInforme.Columns[11].HeaderText = "Fecha en la que eliminó Usuario";
            dgvInforme.Columns[12].HeaderText = "Fecha en la que agregó Grupo";
            dgvInforme.Columns[13].HeaderText = "Fecha en la que eliminó Grupo";
            dgvInforme.Columns[14].HeaderText = "Fecha en la que reseteó clave";
            dgvInforme.Columns[15].HeaderText = "Fecha en la que agregó Usuario";
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            informeCache.filtro = "SI";
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            informeCache.nombreUsuario = txtNombreUsuario.Text;
            if (cbAU.Checked == true)
            {
                informeCache.cbAU = "SI";
            }
            else
            {
                informeCache.cbAU = "NO";
            }
            if (cbMU.Checked == true)
            {
                informeCache.cbMU = "SI";
            }
            else
            {
                informeCache.cbMU = "NO";
            }
            if (cbEU.Checked == true)
            {
                informeCache.cbEU = "SI";
            }
            else
            {
                informeCache.cbEU = "NO";
            }
            if (cbAG.Checked == true)
            {
                informeCache.cbAG = "SI";
            }
            else
            {
                informeCache.cbAG = "NO";
            }
            if (cbMG.Checked == true)
            {
                informeCache.cbMG = "SI";
            }
            else
            {
                informeCache.cbMG = "NO";
            }
            if (cbEG.Checked == true)
            {
                informeCache.cbEG = "SI";
            }
            else
            {
                informeCache.cbEG = "NO";
            }
            DateTime fechaInicio = monthCalendar1.SelectionStart;
            DateTime fechaFin = monthCalendar1.SelectionEnd;

            var tabla = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);
            
            dgvInforme.DataSource = tabla;
            informeCache.tablaEstatica = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            informeCache.filtro = "NO";

            informeCache.cbAU = "NO";
            informeCache.cbMU = "NO";
            informeCache.cbEU = "NO";
            informeCache.cbAG = "NO";
            informeCache.cbMG = "NO";
            informeCache.cbEG = "NO";

            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now;

            var tabla = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);
            dgvInforme.DataSource = tabla;
            informeCache.tablaEstatica = informe.obtenerInforme(txtNombreUsuario.Text, informeCache.cbAU, informeCache.cbMU, informeCache.cbEU, informeCache.cbAG, informeCache.cbMG, informeCache.cbEG, fechaInicio, fechaFin);
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dgvInforme.DataSource = informeCache.tablaEstatica;
            exportarExcel exportarExcel = new exportarExcel();
            exportarExcel.exportarInforme(dgvInforme);
            MessageBox.Show("Archivo exportado");
        }

        private void lblAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu frmMenu = frmMenu.obtenerInstancia();
            frmMenu.Show();
            this.Hide();
        }

        private void dgvInforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
