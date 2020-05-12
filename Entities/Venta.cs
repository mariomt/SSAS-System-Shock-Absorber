using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venta
    {
        public int VentaID { get; set; }
        public User usuario { get; set; }

        public DateTime FechaHora { get; set; }

        public IEnumerable<DescripcionVenta> descripcion { get; set; }
        public double ImporteTotal { get; set; }


    }

    public class DescripcionVenta
    {
        public int DescripcionID { get; set; }
        public int ProductoID { get; set; }
        public int ServicioID { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public bool Cancelado { get; set; }
        public int DescuentoID { get; set; }
    }
}
