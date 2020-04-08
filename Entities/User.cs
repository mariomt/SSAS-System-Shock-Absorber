
using System.Linq;
namespace Entities
{
    public class PartialUser
    {
        public int UsuarioID { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
    }

    public class User: PartialUser
    {
        public Rol rol { get; set; }
    }
}
