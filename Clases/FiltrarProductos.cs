using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Clases

{
    public class ProductoManager
    {
        public static List<Models.Productos> FiltrarProductos(string filtroNombre, string filtroEstado)
        {
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

                return query.ToList();
            }
        }
    }
}
