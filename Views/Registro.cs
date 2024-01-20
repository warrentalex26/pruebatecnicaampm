using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaTecnica.Clases;

namespace PruebaTecnica
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string contrasena = TxtContrasena.Text.Trim();
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string telefono = TxtTelefonoMasked.Text.Trim();

            if (usuario == "" || contrasena == "" || nombre == "" || apellido == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor ingrese un correo válido");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^[0-9]{4}-[0-9]{4}$"))
            {
                MessageBox.Show("Por favor ingrese un teléfono válido");
                return;
            }

            bool usuarioRegistrado = RegistroUsuario.RegistrarUsuario(usuario, contrasena, nombre, apellido, correo, telefono);

            if (usuarioRegistrado)
            {
                MessageBox.Show("Usuario registrado con éxito");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario ya existe o ha ocurrido un error");
            }
        }
    }
}
