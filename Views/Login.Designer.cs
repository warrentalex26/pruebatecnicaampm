namespace PruebaTecnica
{
    partial class Login
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
            this.Lblusuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Location = new System.Drawing.Point(63, 71);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(54, 16);
            this.Lblusuario.TabIndex = 0;
            this.Lblusuario.Text = "Usuario";
            this.Lblusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Location = new System.Drawing.Point(63, 123);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(76, 16);
            this.LblContrasena.TabIndex = 1;
            this.LblContrasena.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(152, 68);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(239, 22);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(152, 120);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(239, 22);
            this.TxtContrasena.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(152, 167);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(115, 23);
            this.BtnIniciarSesion.TabIndex = 4;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Location = new System.Drawing.Point(276, 167);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(115, 23);
            this.BtnRegistro.TabIndex = 5;
            this.BtnRegistro.Text = "Registrarme";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 291);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.Lblusuario);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnRegistro;
    }
}

