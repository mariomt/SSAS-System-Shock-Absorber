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
        IDictionary<string,Regex> validationRegEx;

        public ProductsControl()
        {
            InitializeComponent();
            this.InicializarRegEx();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string validacion = ValidacionFinalDeTextBox();
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
                Tools.Alert("Producto Guardado!", Form_Alert.enumType.Success);
                cargardgv();
            }
            else
            {
                Dictionary<string,string> ValoresDeLosTextos = new Dictionary<string, string>();
                ValoresDeLosTextos.Add("Descripción",descripcionTxt.Text);
                ValoresDeLosTextos.Add("IVA", IVATxt.Text);
                ValoresDeLosTextos.Add("Precio", precioTxt.Text);
                ValoresDeLosTextos.Add("Disponibilidad", disponibilidadTxt.Text);
                Tools.Alert($"Valor invalido en el campo '{validacion}'.\n Valor:{ValoresDeLosTextos[validacion]}", Form_Alert.enumType.Error);
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
        #region validaciones
        private void InicializarRegEx()
        {
            this.validationRegEx = new Dictionary<string, Regex>();
            //Regex para el campo de descripción solo acepta numeros, guión y letras con acentos y diéresis
            this.validationRegEx["regDescripcion"] = new Regex(@"^[\wñÑÁ-ÿ]{1}$|(NumPad[\d])|(D[\d])|(Space)|(Back)|(-)$");
            this.validationRegEx["regDescripcionNoShift"] = new Regex(@"^[\wñÑÁ-ÿ]{1}$|(NumPad[\d])|(Space)|(Back)|(-)$");//prevenimos los caracteres especiales con shift
            this.validationRegEx["regDescripcionesFinal"] = new Regex(@"^[\wÁ-ÿ\s]*$");
            //Regex para el campo de IVA y Precio solo acepta digitos ya sea de del numpad o del principal incluyendo el punto
            this.validationRegEx["regIVA_PrecioVenta"] = new Regex(@"(NumPad[\d])|(D[\d])|(\.)|(Back)|(Decimal)$");
            this.validationRegEx["regIVA_PrecioVentaNoShift"] = new Regex(@"(NumPad[\d])|(\.)|(Back)|(Decimal)$");//prevenimos los caracteres especiales con shift
            this.validationRegEx["regIVA_PrecioFinal"] = new Regex(@"^[\d\.]*$");
            //Regex para el campo de disponibilidad solo acepta digitos del numpad y el teclado original
            this.validationRegEx["regDisponibilidad"] = new Regex(@"(NumPad[\d])|(D[\d])|(Back)$");
            this.validationRegEx["regDisponibilidadNoShift"] = new Regex(@"(NumPad[\d])|(Back)$");//prevenimos los caracteres especiales con shift
            this.validationRegEx["regDisponibilidadFinal"] = new Regex(@"^[\d]*$");

        }

        private void descripcionTxt_KeyDown(object sender,KeyEventArgs e)
        {
            e.SuppressKeyPress = this.validarTextBox(e, this.validationRegEx["regDescripcion"], this.validationRegEx["regDescripcionNoShift"]);
        }

        private void IVATxt_KeyDown(object sender,KeyEventArgs e)
        {
            e.SuppressKeyPress = this.validarTextBox(e, this.validationRegEx["regIVA_PrecioVenta"], this.validationRegEx["regIVA_PrecioVentaNoShift"]);
        }

        private void precioTxt_KeyDown(object sender,KeyEventArgs e)
        {
            e.SuppressKeyPress = this.validarTextBox(e, this.validationRegEx["regIVA_PrecioVenta"], this.validationRegEx["regIVA_PrecioVentaNoShift"]);
        }

        private void disponibilidadTxt_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = this.validarTextBox(e, this.validationRegEx["regDisponibilidad"], this.validationRegEx["regDisponibilidadNoShift"]);
        }

        private Boolean validarTextBox(KeyEventArgs e,Regex reg,Regex regNoShift)
        {
            string tecla = e.KeyCode.ToString();
            Match match;
            if (e.Shift)
            {
                match = regNoShift.Match(tecla);//usamos el Regex que excluye el shift
            }
            else
            {
                match = reg.Match(tecla);//usamos el Regex que acepta el shift
            }
            return !match.Success;//valor "false" deja pasar el el teclado, valor "true" no deja pasar el teclado
        }

        private string ValidacionFinalDeTextBox()
        {
            if (!this.validationRegEx["regDescripcionesFinal"].Match(descripcionTxt.Text).Success)
            {
                return "Descripción";
            }
            if (!this.validationRegEx["regIVA_PrecioFinal"].Match(IVATxt.Text).Success)
            {
                return "IVA";
            }
            if (!this.validationRegEx["regIVA_PrecioFinal"].Match(precioTxt.Text).Success)
            {
                return "Precio";
            }
            if (!this.validationRegEx["regDisponibilidadFinal"].Match(disponibilidadTxt.Text).Success)
            {
                return "Disponibilidad";
            }
            return "";
        }
        #endregion

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
                productoseleccionado.Disponibilidad = int.Parse(selectedRow.Cells[3].Value.ToString());
                productoseleccionado.PrecioVenta = double.Parse(selectedRow.Cells[4].Value.ToString());
                productoseleccionado.Activo = (bool)selectedRow.Cells[5].Value;

                


                Cancellation desactivar = new Cancellation(EnumTypeOperation.DisableService);

                BitacoraOperaciones bitacoraOP = desactivar.showDialog(this);
                if (bitacoraOP != null)
                {
                    ProductDomain producto = new ProductDomain();
                    productoseleccionado.Activo = false;
                    if (producto.bajaproducto(productoseleccionado, bitacoraOP))
                    {
                        Tools.Alert("Se dio de baja el producto", Form_Alert.enumType.Success);

                        cargardgv();
                    }
                    else
                    {
                        Tools.Alert("Error al guardar la informacion", Form_Alert.enumType.Error);
                    }
                        

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Tools.Alert("No se selecciono ningun registro",Form_Alert.enumType.Error);
            }
            




        }
       
    }
}
