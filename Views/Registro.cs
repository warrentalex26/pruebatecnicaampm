using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string telefono = TxtTelefono.Text.Trim();

            if (usuario == "" || contrasena == "" || nombre == "" || apellido == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            else
            {
                try
                {
                    using (Models.DBProductosEntities db = new Models.DBProductosEntities())
                    {
                        Models.Usuarios usuarioNuevo = new Models.Usuarios();
                        usuarioNuevo.nombreUsuario = usuario;
                        usuarioNuevo.contraseña = contrasena;
                        usuarioNuevo.nombre = nombre;
                        usuarioNuevo.apellido = apellido;
                        usuarioNuevo.correo = correo;
                        usuarioNuevo.telefono = telefono;
                        usuarioNuevo.fechaCreacion = DateTime.Now;
                        db.Usuarios.Add(usuarioNuevo);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Usuario registrado con éxito");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("El usuario ya existe");
                }   
            }
        }
    }
}
