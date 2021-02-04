namespace VISTA
{
    partial class frmCambiarContraseña
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.txtRepetirNuevaClave = new System.Windows.Forms.TextBox();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.lblRepetirNuevaClave = new System.Windows.Forms.Label();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(228, 169);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(72, 169);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 28);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(207, 67);
            this.txtNuevaClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '*';
            this.txtNuevaClave.Size = new System.Drawing.Size(239, 22);
            this.txtNuevaClave.TabIndex = 12;
            // 
            // txtRepetirNuevaClave
            // 
            this.txtRepetirNuevaClave.Location = new System.Drawing.Point(207, 112);
            this.txtRepetirNuevaClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetirNuevaClave.Name = "txtRepetirNuevaClave";
            this.txtRepetirNuevaClave.PasswordChar = '*';
            this.txtRepetirNuevaClave.Size = new System.Drawing.Size(239, 22);
            this.txtRepetirNuevaClave.TabIndex = 13;
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(207, 22);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(239, 22);
            this.txtClaveActual.TabIndex = 11;
            // 
            // lblRepetirNuevaClave
            // 
            this.lblRepetirNuevaClave.AutoSize = true;
            this.lblRepetirNuevaClave.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirNuevaClave.Location = new System.Drawing.Point(23, 116);
            this.lblRepetirNuevaClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepetirNuevaClave.Name = "lblRepetirNuevaClave";
            this.lblRepetirNuevaClave.Size = new System.Drawing.Size(166, 18);
            this.lblRepetirNuevaClave.TabIndex = 10;
            this.lblRepetirNuevaClave.Text = "Repita la nueva clave:";
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.Location = new System.Drawing.Point(15, 71);
            this.lblContraseñaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(174, 18);
            this.lblContraseñaNueva.TabIndex = 9;
            this.lblContraseñaNueva.Text = "Ingrese la nueva clave:";
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaActual.Location = new System.Drawing.Point(11, 26);
            this.lblContraseñaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(178, 18);
            this.lblContraseñaActual.TabIndex = 8;
            this.lblContraseñaActual.Text = "Ingrese su clave actual:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClaveActual);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.lblContraseñaActual);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.lblContraseñaNueva);
            this.groupBox1.Controls.Add(this.txtNuevaClave);
            this.groupBox1.Controls.Add(this.lblRepetirNuevaClave);
            this.groupBox1.Controls.Add(this.txtRepetirNuevaClave);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 223);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(327, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "AAAAAAAAAAAAAAA";
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCambiarContraseña";
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.TextBox txtRepetirNuevaClave;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label lblRepetirNuevaClave;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}