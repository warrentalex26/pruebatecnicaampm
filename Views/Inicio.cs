using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaTecnica.Clases;

namespace PruebaTecnica.Views
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.dBProductosDataSet.Productos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                byte[] imagen = GestionarImagen.SeleccionarYConvertirImagen();
                if (imagen != null)
                {
                    int idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    GestionarImagen.GuardarImagenEnBaseDeDatos(idProducto, imagen);

                    Image imagenMostrar = Image.FromStream(new MemoryStream(imagen));
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = imagenMostrar;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            string filtroNombre = TxtBuscar.Text.Trim();
            string filtroEstado = null;

            switch (CbEstado.SelectedItem?.ToString())
            {
                case "Activo":
                    filtroEstado = "1";
                    break;
                case "Inactivo":
                    filtroEstado = "0";
                    break;
            }

            using (var db = new Models.DBProductosEntities())
            {
                var query = db.Productos.AsQueryable();

                if (!string.IsNullOrEmpty(filtroNombre))
                {
                    query = query.Where(p => p.nombre.Contains(filtroNombre));
                }

                if (filtroEstado != null)
                {
                    bool estadoBool = filtroEstado == "1";
                    query = query.Where(p => p.estado == estadoBool);
                }

                var productosFiltrados = query.ToList();
                dataGridView1.DataSource = productosFiltrados;
            }
        }

    }
}
