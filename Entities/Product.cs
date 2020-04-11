using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public int Disponibilidad { get; set; }
        public double IVA { get; set; }
        public bool Activo { get; set; }
    }
}
