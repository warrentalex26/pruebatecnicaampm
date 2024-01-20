using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Clases
{
    public class RegistroUsuario
    {
        public static bool RegistrarUsuario(string usuario, string contrasena, string nombre, string apellido, string correo, string telefono)
        {
            try
            {
                using (var db = new Models.DBProductosEntities())
                {
                    var usuarioNuevo = new Models.Usuarios
                    {
                        nombreUsuario = usuario,
                        contraseña = contrasena,
                        nombre = nombre,
                        apellido = apellido,
                        correo = correo,
                        telefono = telefono,
                        fechaCreacion = DateTime.Now
                    };

                    db.Usuarios.Add(usuarioNuevo);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
