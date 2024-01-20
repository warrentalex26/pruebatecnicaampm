namespace PruebaTecnica
{
    partial class Registro
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefonoMasked = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(48, 56);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(54, 16);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Location = new System.Drawing.Point(48, 106);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(76, 16);
            this.LblContrasena.TabIndex = 1;
            this.LblContrasena.Text = "Contraseña";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(48, 154);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(48, 204);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(48, 259);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(48, 16);
            this.LblCorreo.TabIndex = 4;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(144, 56);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(234, 22);
            this.TxtUsuario.TabIndex = 5;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(144, 99);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(234, 22);
            this.TxtContrasena.TabIndex = 6;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(144, 148);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(144, 201);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(234, 22);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(144, 259);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(234, 22);
            this.TxtCorreo.TabIndex = 9;
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Location = new System.Drawing.Point(204, 376);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRegistro.Size = new System.Drawing.Size(99, 34);
            this.BtnRegistro.TabIndex = 10;
            this.BtnRegistro.Text = "Registro";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(48, 323);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(61, 16);
            this.LblTelefono.TabIndex = 11;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtTelefonoMasked
            // 
            this.TxtTelefonoMasked.Location = new System.Drawing.Point(144, 320);
            this.TxtTelefonoMasked.Mask = "0000-0000";
            this.TxtTelefonoMasked.Name = "TxtTelefonoMasked";
            this.TxtTelefonoMasked.Size = new System.Drawing.Size(83, 22);
            this.TxtTelefonoMasked.TabIndex = 13;
            this.TxtTelefonoMasked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 482);
            this.Controls.Add(this.TxtTelefonoMasked);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.MaskedTextBox TxtTelefonoMasked;
    }
}