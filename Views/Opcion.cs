using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.Views
{
    public partial class Opcion : Form
    {
        private int idProducto;
        public Opcion(int idProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
        }

        private void Opcion_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var opcion = TxtOpcion.Text;
            var productoRelacionado = this.idProducto;
            bool estado = false;

            switch (CbEstado.SelectedItem?.ToString())
            {
                case "Activo":
                    estado = true;
                    break;
                case "Inactivo":
                    estado = false;
                    break;
            }

            using (Models.DBProductosEntities db = new Models.DBProductosEntities())
            {
                Models.Opciones nuevaOpcion = new Models.Opciones();
                nuevaOpcion.nombreOpcion = opcion;
                nuevaOpcion.productoRelacionado = productoRelacionado;
                nuevaOpcion.estado = estado;
                db.Opciones.Add(nuevaOpcion);
                db.SaveChanges();

            }
            MessageBox.Show("Opción guardada con éxito");
            this.Close();
        }
    }
}
