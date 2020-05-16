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
using System.Text.RegularExpressions;
using System.Data.SqlClient;



namespace Cliente
{
    public partial class ProductsControl : UserControl
    {
        Product productoseleccionado;

        public ProductsControl()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductDomain productDomain = new ProductDomain();
            string validacion = productDomain.validateFormProduct(descripcionTxt.Text,IVATxt.Text,disponibilidadTxt.Text,precioTxt.Text);
            if (validacion.Length == 0)
            {
                Product producto = new Product()
                {
                    Descripcion = descripcionTxt.Text,
                    PrecioVenta = Double.Parse(precioTxt.Text),
                    Disponibilidad = Int32.Parse(disponibilidadTxt.Text),
                    IVA = Double.Parse(IVATxt.Text),
                    Activo = activoChk.Checked
                };

                new ProductDomain().insertNewProduct(ref producto);
                Tools.AlertInToApp("Producto Guardado!", Form_Alert.enumType.Success);
                cargardgv();
            }
            else
            {
                Tools.AlertInToApp(validacion, Form_Alert.enumType.Error);
            }
        
            this.cleanForm();
            
        }


        private void cleanForm()
        {
            descripcionTxt.Text = "";
            precioTxt.Text = "";
            disponibilidadTxt.Text = "";
            IVATxt.Text = "";
            activoChk.Checked = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           var productos = new ProductDomain().SearchProducts(txtBuscar.Text);
            dataGridView1.Rows.Clear();
            foreach(var producto in productos)
            {
                DataGridViewRow celda = new DataGridViewRow();
                celda.CreateCells(dataGridView1);
                celda.Cells[0].Value = producto.ProductoID;
                celda.Cells[1].Value = producto.Descripcion;
                celda.Cells[2].Value = producto.IVA;
                celda.Cells[3].Value = producto.PrecioVenta;
                celda.Cells[4].Value = producto.Disponibilidad;
                celda.Cells[5].Value = producto.Activo;
                dataGridView1.Rows.Add(celda);
            }
        }
        private void cargardgv()
        {
            dataGridView1.Rows.Clear();
            ProductDomain productos = new ProductDomain();
            var listaproductos  = productos.getProducts();
            foreach (var producto in listaproductos)
            {
                DataGridViewRow celda = new DataGridViewRow();
                celda.CreateCells(dataGridView1);
                celda.Cells[0].Value = producto.ProductoID;
                celda.Cells[1].Value = producto.Descripcion;
                celda.Cells[2].Value = producto.IVA;
                celda.Cells[3].Value = producto.PrecioVenta;
                celda.Cells[4].Value = producto.Disponibilidad;
                celda.Cells[5].Value = producto.Activo;
                dataGridView1.Rows.Add(celda);
            }

        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {

            cargardgv();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void disponibilidadTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionTxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection index = dataGridView1.SelectedRows;
                DataGridViewRow selectedRow = index[0];
                productoseleccionado = new Product();

                productoseleccionado.ProductoID = (int)selectedRow.Cells[0].Value;
                productoseleccionado.Descripcion = selectedRow.Cells[1].Value.ToString();
                productoseleccionado.IVA = double.Parse(selectedRow.Cells[2].Value.ToString());
                productoseleccionado.PrecioVenta = double.Parse(selectedRow.Cells[3].Value.ToString());
                productoseleccionado.Disponibilidad = int.Parse(selectedRow.Cells[4].Value.ToString());
                productoseleccionado.Activo = (bool)selectedRow.Cells[5].Value;



                Cancellation desactivar = new Cancellation(EnumTypeOperation.DisableService);

                BitacoraOperaciones bitacoraOP = desactivar.showDialog(this);
                if (bitacoraOP != null)
                {
                   ProductDomain producto = new ProductDomain();
                    productoseleccionado.Activo = false;
                    if (producto.bajaproducto(productoseleccionado, bitacoraOP))
                    {
                        Tools.AlertInToApp("Se dio de baja el producto", Form_Alert.enumType.Success);

                        cargardgv();
                    }
                    else
                    {
                        Tools.AlertInToApp("Error al guardar la información", Form_Alert.enumType.Error);
                    }
                        

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Tools.AlertInToApp("No se seleccionó ningún registro",Form_Alert.enumType.Error);
            }
            




        }
       
    }
}
