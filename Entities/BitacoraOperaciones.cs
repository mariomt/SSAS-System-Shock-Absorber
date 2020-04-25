using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BitacoraOperaciones
    {
        public int OperacionID { get; set; }
        public int TipoID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaHora { get; set; }
        public string Comentario { get; set; }
    }
}
