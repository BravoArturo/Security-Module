namespace VISTA
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarGrupos = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMisDatos = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(458, 20);
            this.btnGestionarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(223, 46);
            this.btnGestionarUsuarios.TabIndex = 3;
            this.btnGestionarUsuarios.Text = "Gestionar usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarGrupos
            // 
            this.btnGestionarGrupos.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarGrupos.Location = new System.Drawing.Point(185, 20);
            this.btnGestionarGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionarGrupos.Name = "btnGestionarGrupos";
            this.btnGestionarGrupos.Size = new System.Drawing.Size(223, 46);
            this.btnGestionarGrupos.TabIndex = 2;
            this.btnGestionarGrupos.Text = "Gestionar grupos";
            this.btnGestionarGrupos.UseVisualStyleBackColor = true;
            this.btnGestionarGrupos.Click += new System.EventHandler(this.btnGestionarGrupos_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogOut.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(990, 7);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(191, 29);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMisDatos
            // 
            this.btnMisDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMisDatos.BackgroundImage")));
            this.btnMisDatos.Location = new System.Drawing.Point(13, 561);
            this.btnMisDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMisDatos.Name = "btnMisDatos";
            this.btnMisDatos.Size = new System.Drawing.Size(117, 96);
            this.btnMisDatos.TabIndex = 5;
            this.btnMisDatos.UseVisualStyleBackColor = true;
            this.btnMisDatos.Click += new System.EventHandler(this.btnMisDatos_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(729, 20);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(223, 46);
            this.btnInforme.TabIndex = 6;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 681);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnMisDatos);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Controls.Add(this.btnGestionarGrupos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionarGrupos;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMisDatos;
        private System.Windows.Forms.Button btnInforme;
    }
}

