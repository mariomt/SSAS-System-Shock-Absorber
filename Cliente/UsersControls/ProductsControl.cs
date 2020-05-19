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
        int productoseleccionadoId = 0;

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
                if (button1.Text == "Agregar")
                {
                    productDomain.insertNewProduct(ref producto);
                    Tools.AlertInToApp("Producto Guardado!", Form_Alert.enumType.Success);
                    cargardgv();
                    cleanForm();
                } else if(button1.Text == "Actualizar")
                {
                    producto.ProductoID = this.productoseleccionadoId;
                    if (productDomain.updateProduct(producto))
                    {
                        Tools.AlertInToApp("Producto actualizado con éxito!", Form_Alert.enumType.Success);
                        cargardgv();
                        cleanForm();
                    }
                    else
                        Tools.AlertInToApp("Ups! ocurrio un error, intentalo de nuevo.", Form_Alert.enumType.Error);
                }
                else
                {
                    Tools.AlertInToApp(string.Format("Operación {0} no valida", button1.Text), Form_Alert.enumType.Error);
                }
                
            }
            else
            {
                Tools.AlertInToApp(validacion, Form_Alert.enumType.Error);
            }
            
        }


        private void cleanForm()
        {
            descripcionTxt.Text = "";
            precioTxt.Text = "";
            disponibilidadTxt.Text = "";
            IVATxt.Text = "";
            activoChk.Checked = true;

            button1.Text = "Agregar";
            this.productoseleccionadoId = 0;
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
            cleanForm();
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {

            cargardgv();

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection usuarioSeleccionado = dataGridView1.Rows[e.RowIndex].Cells;
            var id = usuarioSeleccionado[0].Value;
            this.productoseleccionadoId = Int32.Parse(id.ToString());

            descripcionTxt.Text = usuarioSeleccionado[1].Value.ToString();
            IVATxt.Text = usuarioSeleccionado[2].Value.ToString();
            disponibilidadTxt.Text = usuarioSeleccionado[4].Value.ToString();
            precioTxt.Text = usuarioSeleccionado[3].Value.ToString();
            activoChk.Checked = bool.Parse(usuarioSeleccionado[5].Value.ToString());

            button1.Text = "Actualizar";
        }
    }
}
