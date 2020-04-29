using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Batch
    {
        public int LoteID { get; set; }
        public int ProductoID { get; set; }
        public DateTime FechaHora { get; set; }
        public Double Importe { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }
    }
}
