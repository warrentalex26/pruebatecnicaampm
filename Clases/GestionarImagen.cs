using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
                return File.ReadAllBytes(fileDialog.FileName);
            }
            return null;
        }

        public static void GuardarImagenEnBaseDeDatos(int idProducto, byte[] imagen, Size tamañoDeseado)
        {
            try
            {
                Image imagenOriginal = Image.FromStream(new MemoryStream(imagen));
                Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, tamañoDeseado);

                using (MemoryStream ms = new MemoryStream())
                {
                    imagenRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imagenBytes = ms.ToArray();

                    using (Models.DBProductosEntities db = new Models.DBProductosEntities())
                    {
                        Models.Productos producto = db.Productos.Find(idProducto);
                        producto.imagenProducto = imagenBytes;
                        db.SaveChanges();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("El archivo seleccionado no es una imagen válida.");
            }
        }


        public static Image RedimensionarImagen(Image imagenOriginal, Size tamaño)
        {
            return (Image)(new Bitmap(imagenOriginal, tamaño));
        }
    }
}
