using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaTecnica.Clases;
using PruebaTecnica.Views;

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
            int idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 6)
            {
                byte[] imagen = GestionarImagen.SeleccionarYConvertirImagen();
                if (imagen != null)
                {
                    GestionarImagen.GuardarImagenEnBaseDeDatos(idProducto, imagen);
                    Image imagenMostrar = Image.FromStream(new MemoryStream(imagen));
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = imagenMostrar;
                }
            }
            if (e.ColumnIndex == 7)
            {
                
                MostrarOpcionesDelProducto(idProducto);
            }

            if (e.ColumnIndex == 8)
            {
                Opcion opcionForm = new Opcion(idProducto);
                opcionForm.FormClosed += new FormClosedEventHandler(OpcionForm_FormClosed);
                opcionForm.ShowDialog();
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

        private void MostrarOpcionesDelProducto(int idProducto)
        {
            using (var db = new Models.DBProductosEntities())
            {
                var opciones = db.Opciones.Where(o => o.productoRelacionado == idProducto).ToList();

                if (opciones.Any())
                {
                    StringBuilder opcionesTexto = new StringBuilder();
                    foreach (var opcion in opciones)
                    {
                        opcionesTexto.AppendLine(opcion.nombreOpcion);
                    }

                    MessageBox.Show(opcionesTexto.ToString(), "Opciones del Producto");
                }
                else
                {
                    MessageBox.Show("Este producto no tiene opciones asociadas.", "Sin Opciones");
                }
            }
        }

        private void OpcionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FiltrarProductos();
        }

        private void productosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
