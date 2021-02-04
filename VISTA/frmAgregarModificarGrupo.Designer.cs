namespace VISTA
{
    partial class frmAgregarModificarGrupo
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
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.cbModificar = new System.Windows.Forms.CheckBox();
            this.cbAgregar = new System.Windows.Forms.CheckBox();
            this.lblAccionesPermitidas = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.cbEliminar);
            this.pnlAcciones.Controls.Add(this.cbModificar);
            this.pnlAcciones.Controls.Add(this.cbAgregar);
            this.pnlAcciones.Location = new System.Drawing.Point(184, 126);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(130, 85);
            this.pnlAcciones.TabIndex = 28;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEliminar.Location = new System.Drawing.Point(4, 60);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(86, 21);
            this.cbEliminar.TabIndex = 2;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // cbModificar
            // 
            this.cbModificar.AutoSize = true;
            this.cbModificar.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModificar.Location = new System.Drawing.Point(4, 32);
            this.cbModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbModificar.Name = "cbModificar";
            this.cbModificar.Size = new System.Drawing.Size(94, 21);
            this.cbModificar.TabIndex = 1;
            this.cbModificar.Text = "Modificar";
            this.cbModificar.UseVisualStyleBackColor = true;
            // 
            // cbAgregar
            // 
            this.cbAgregar.AutoSize = true;
            this.cbAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgregar.Location = new System.Drawing.Point(4, 4);
            this.cbAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAgregar.Name = "cbAgregar";
            this.cbAgregar.Size = new System.Drawing.Size(86, 21);
            this.cbAgregar.TabIndex = 0;
            this.cbAgregar.Text = "Agregar";
            this.cbAgregar.UseVisualStyleBackColor = true;
            // 
            // lblAccionesPermitidas
            // 
            this.lblAccionesPermitidas.AutoSize = true;
            this.lblAccionesPermitidas.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionesPermitidas.Location = new System.Drawing.Point(16, 155);
            this.lblAccionesPermitidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccionesPermitidas.Name = "lblAccionesPermitidas";
            this.lblAccionesPermitidas.Size = new System.Drawing.Size(161, 18);
            this.lblAccionesPermitidas.TabIndex = 27;
            this.lblAccionesPermitidas.Text = "Acciones permitidas:";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.Location = new System.Drawing.Point(16, 96);
            this.lblNombreGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(73, 18);
            this.lblNombreGrupo.TabIndex = 26;
            this.lblNombreGrupo.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(166, 242);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 26);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(22, 242);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 26);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(97, 92);
            this.txtNombreGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(218, 22);
            this.txtNombreGrupo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(147, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "AAAAAAAAAAAAAAA";
            // 
            // frmAgregarModificarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.lblAccionesPermitidas);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarModificarGrupo";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "ABM grupos";
            this.Load += new System.EventHandler(this.frmAgregarModificarGrupo_Load);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.CheckBox cbModificar;
        private System.Windows.Forms.CheckBox cbAgregar;
        private System.Windows.Forms.Label lblAccionesPermitidas;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label label3;
    }
}