using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Cliente
{
    public partial class UserProductos : UserControl
    {
        public UserProductos()
        {
            InitializeComponent();
        }

        private void UserProductos_Load(object sender, EventArgs e)
        {
            cargardgv();

        }
        private void cargardgv()
        {
            ProductDomain productos = new ProductDomain();
            var listaproductos = productos.getProducts();
            foreach (var producto in listaproductos)
            {
                Console.WriteLine(producto.Descripcion);
                Console.WriteLine(producto.ProductoID);
                Console.WriteLine(producto.IVA);
                Console.WriteLine(producto.PrecioVenta);

            }
        }
    }
}
