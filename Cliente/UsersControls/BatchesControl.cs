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

        private void cargaComboBoxProductos()
        {
            ProductDomain productos = new ProductDomain();
            var listaproductos = productos.getProducts();

            Dictionary<int,string> productsDictionary = new Dictionary<int, string>();
            productsDictionary.Add(-1, "");
            foreach (var producto in listaproductos)
            {
                productsDictionary.Add(producto.ProductoID,producto.Descripcion);
            }
            ProductoCb.DataSource = new BindingSource(productsDictionary, null);
            ProductoCb.DisplayMember = "Value";
            ProductoCb.ValueMember = "Key";
            ProductoCb.AutoCompleteMode = AutoCompleteMode.Suggest;
            ProductoCb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cleanForm()
        {
            ProductoCb.SelectedValue = -1;
            importeTxt.Text = "";
            cantidadTxt.Text = "";
            activoChk.Checked = false;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            BatchDomain batchDomain = new BatchDomain();
            
            int productIdSelected = ((KeyValuePair<int,string>)this.ProductoCb.SelectedItem).Key;
            string validateMsg = batchDomain.validateFormInsertBatch(productIdSelected,importeTxt.Text,cantidadTxt.Text);

            if (validateMsg.Length == 0)
            {
                double importeDecimal = double.Parse(importeTxt.Text);
                int cantidadInt = Int32.Parse(cantidadTxt.Text);
                Batch batch = new Batch()
                {
                    ProductoID = productIdSelected,
                    FechaHora = DateTime.Now,
                    Importe = importeDecimal,
                    Cantidad = cantidadInt,
                    Activo = activoChk.Checked
                };

                batchDomain.insertBatch(ref batch);

                Tools.Alert("Lote Guardado!", Form_Alert.enumType.Success);
                cleanForm();
            }
            else
            {
                Tools.Alert(validateMsg,Form_Alert.enumType.Warning);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void ProductoCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BatchesControl_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
