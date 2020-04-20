
using System.Linq;
namespace Entities
{
    public class PartialUser
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public bool Activo { get; set; }
    }

    public class User: PartialUser
    {
        public Rol rol { get; set; }
    }
}
