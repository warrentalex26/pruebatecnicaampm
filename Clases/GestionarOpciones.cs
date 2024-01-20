using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Clases
{
    public class GestionarOpciones
    {
        public static void GuardarOpcion(string nombreOpcion, int productoRelacionado, bool estado)
        {
            using (var db = new Models.DBProductosEntities())
            {
                var nuevaOpcion = new Models.Opciones
                {
                    nombreOpcion = nombreOpcion,
                    productoRelacionado = productoRelacionado,
                    estado = estado
                };

                db.Opciones.Add(nuevaOpcion);
                db.SaveChanges();
            }
        }
    }
}
