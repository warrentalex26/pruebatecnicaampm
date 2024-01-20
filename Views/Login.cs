using PruebaTecnica.Views;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string contrasena = TxtContrasena.Text.Trim();

            using (Models.DBProductosEntities db = new Models.DBProductosEntities())
            {
                var lista = from d in db.Usuarios
                            where d.nombreUsuario == usuario && d.contraseña == contrasena
                            select d;

                if (lista.Count() > 0)
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
