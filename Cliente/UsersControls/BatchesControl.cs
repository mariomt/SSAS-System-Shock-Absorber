using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Domain;

namespace Cliente.UsersControls
{
    public partial class BatchesControl : UserControl
    {
        public BatchesControl()
        {
            InitializeComponent();
            cargaComboBoxProductos();
        }

        public void cargaComboBoxProductos()
        {
            ProductDomain productos = new ProductDomain();
            var listaproductos = productos.getProducts();

            Dictionary<string,string> productsDictionary = new Dictionary<string, string>();
            foreach (var producto in listaproductos)
            {
                productsDictionary.Add(producto.ProductoID.ToString(),producto.Descripcion);
            }
            ProductoCb.DataSource = new BindingSource(productsDictionary, null);
            ProductoCb.DisplayMember = "Value";
            ProductoCb.ValueMember = "Key";
            ProductoCb.AutoCompleteMode = AutoCompleteMode.Suggest;
            ProductoCb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
