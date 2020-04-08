

namespace Entities
{
    public class User
    {
        public int UsuarioID { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int RolID { get; set; }
        public bool Activo { get; set; }
    }
}
