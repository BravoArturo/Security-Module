namespace VISTA.INFORME
{
    partial class frmInforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforme));
            this.btnFiltro = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.cbEG = new System.Windows.Forms.CheckBox();
            this.cbMG = new System.Windows.Forms.CheckBox();
            this.cbAG = new System.Windows.Forms.CheckBox();
            this.cbEU = new System.Windows.Forms.CheckBox();
            this.cbMU = new System.Windows.Forms.CheckBox();
            this.cbAU = new System.Windows.Forms.CheckBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInforme = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltro.BackgroundImage")));
            this.btnFiltro.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(25, 403);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 28);
            this.btnFiltro.TabIndex = 1;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.cbEG);
            this.gbAcciones.Controls.Add(this.cbMG);
            this.gbAcciones.Controls.Add(this.cbAG);
            this.gbAcciones.Controls.Add(this.cbEU);
            this.gbAcciones.Controls.Add(this.cbMU);
            this.gbAcciones.Controls.Add(this.cbAU);
            this.gbAcciones.Location = new System.Drawing.Point(8, 86);
            this.gbAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.gbAcciones.Size = new System.Drawing.Size(314, 240);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // cbEG
            // 
            this.cbEG.AutoSize = true;
            this.cbEG.Location = new System.Drawing.Point(163, 208);
            this.cbEG.Margin = new System.Windows.Forms.Padding(4);
            this.cbEG.Name = "cbEG";
            this.cbEG.Size = new System.Drawing.Size(137, 22);
            this.cbEG.TabIndex = 5;
            this.cbEG.Text = "Eliminar grupo";
            this.cbEG.UseVisualStyleBackColor = true;
            // 
            // cbMG
            // 
            this.cbMG.AutoSize = true;
            this.cbMG.Location = new System.Drawing.Point(163, 111);
            this.cbMG.Margin = new System.Windows.Forms.Padding(4);
            this.cbMG.Name = "cbMG";
            this.cbMG.Size = new System.Drawing.Size(149, 22);
            this.cbMG.TabIndex = 4;
            this.cbMG.Text = "Modificar grupo";
            this.cbMG.UseVisualStyleBackColor = true;
            // 
            // cbAG
            // 
            this.cbAG.AutoSize = true;
            this.cbAG.Location = new System.Drawing.Point(163, 23);
            this.cbAG.Margin = new System.Windows.Forms.Padding(4);
            this.cbAG.Name = "cbAG";
            this.cbAG.Size = new System.Drawing.Size(139, 22);
            this.cbAG.TabIndex = 3;
            this.cbAG.Text = "Agregar grupo";
            this.cbAG.UseVisualStyleBackColor = true;
            // 
            // cbEU
            // 
            this.cbEU.AutoSize = true;
            this.cbEU.Location = new System.Drawing.Point(10, 208);
            this.cbEU.Margin = new System.Windows.Forms.Padding(4);
            this.cbEU.Name = "cbEU";
            this.cbEU.Size = new System.Drawing.Size(145, 22);
            this.cbEU.TabIndex = 2;
            this.cbEU.Text = "Eliminar usuario";
            this.cbEU.UseVisualStyleBackColor = true;
            // 
            // cbMU
            // 
            this.cbMU.AutoSize = true;
            this.cbMU.Location = new System.Drawing.Point(8, 111);
            this.cbMU.Margin = new System.Windows.Forms.Padding(4);
            this.cbMU.Name = "cbMU";
            this.cbMU.Size = new System.Drawing.Size(157, 22);
            this.cbMU.TabIndex = 1;
            this.cbMU.Text = "Modificar usuario";
            this.cbMU.UseVisualStyleBackColor = true;
            // 
            // cbAU
            // 
            this.cbAU.AutoSize = true;
            this.cbAU.Location = new System.Drawing.Point(8, 23);
            this.cbAU.Margin = new System.Windows.Forms.Padding(4);
            this.cbAU.Name = "cbAU";
            this.cbAU.Size = new System.Drawing.Size(147, 22);
            this.cbAU.TabIndex = 0;
            this.cbAU.Text = "Agregar usuario";
            this.cbAU.UseVisualStyleBackColor = true;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(8, 47);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(568, 31);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese nombre de usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvInforme
            // 
            this.dgvInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme.Location = new System.Drawing.Point(633, 73);
            this.dgvInforme.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInforme.Name = "dgvInforme";
            this.dgvInforme.RowHeadersWidth = 51;
            this.dgvInforme.Size = new System.Drawing.Size(582, 358);
            this.dgvInforme.TabIndex = 5;
            this.dgvInforme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforme_CellContentClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(25, 23);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOriginal.BackgroundImage")));
            this.btnOriginal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginal.Location = new System.Drawing.Point(131, 403);
            this.btnOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(251, 28);
            this.btnOriginal.TabIndex = 7;
            this.btnOriginal.Text = "Mostrar original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.gbAcciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 331);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades del filtro:";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(386, 403);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(229, 28);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Obtener excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(1052, 7);
            this.lblAtras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(230, 18);
            this.lblAtras.TabIndex = 10;
            this.lblAtras.TabStop = true;
            this.lblAtras.Text = "<--- Volver al menú principal";
            this.lblAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAtras_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(329, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 240);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elegir fechas del informe:";
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 449);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.dgvInforme);
            this.Controls.Add(this.btnFiltro);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInforme";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.CheckBox cbEG;
        private System.Windows.Forms.CheckBox cbMG;
        private System.Windows.Forms.CheckBox cbAG;
        private System.Windows.Forms.CheckBox cbEU;
        private System.Windows.Forms.CheckBox cbMU;
        private System.Windows.Forms.CheckBox cbAU;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInforme;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.LinkLabel lblAtras;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}