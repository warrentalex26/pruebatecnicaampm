using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.Clases
{
    public class GestionarImagen
    {
        public static byte[] SeleccionarYConvertirImagen()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            fileDialog.Title = "Seleccione una imagen";
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return System.IO.File.ReadAllBytes(fileDialog.FileName);
            }
            return null;
        }

        public static void GuardarImagenEnBaseDeDatos(int idProducto, byte[] imagen)
        {
            using (Models.DBProductosEntities db = new Models.DBProductosEntities())
            {
                Models.Productos producto = db.Productos.Find(idProducto);
                producto.imagenProducto = imagen;
                db.SaveChanges();
            }
        }
    }
}
