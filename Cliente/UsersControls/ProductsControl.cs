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
        IDictionary<string,Regex> validationRegEx;

        public ProductsControl()
        {
            InitializeComponent();
            this.InicializarRegEx();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            int bla = Int32.Parse(disponibilidadTxt.Text);
            Product producto = new Product()
            {
                Descripcion = descripcionTxt.Text,
                PrecioVenta = Double.Parse(precioTxt.Text),
                Disponibilidad = Int32.Parse(disponibilidadTxt.Text),
                IVA = Double.Parse(IVATxt.Text),
                Activo = activoChk.Checked

               
            };

            new ProductDomain().insertNewProduct(ref producto);
        
            this.cleanForm();
            cargardgv();
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
            //Regex para el campo de IVA y Precio solo acepta digitos ya sea de del numpad o del principal incluyendo el punto
            this.validationRegEx["regIVA_PrecioVenta"] = new Regex(@"(NumPad[\d])|(D[\d])|(\.)|(Back)$");
            this.validationRegEx["regIVA_PrecioVentaNoShift"] = new Regex(@"(NumPad[\d])|(\.)|(Back)$");//prevenimos los caracteres especiales con shift
            //Regex para el campo de disponibilidad solo acepta digitos del numpad y el teclado original
            this.validationRegEx["regDisponibilidad"] = new Regex(@"(NumPad[\d])|(D[\d])|(Back)$");
            this.validationRegEx["regDisponibilidadNoShift"] = new Regex(@"(NumPad[\d])|(Back)$");//prevenimos los caracteres especiales con shift

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

        string IdProductSelected = "";
        string MotivoCancelacion = "";
        private void iconButton2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection index = dataGridView1.SelectedRows;
            DataGridViewRow selectedRow = index[0];
            IdProductSelected = selectedRow.Cells[0].Value.ToString();
            InputForm desactive = new InputForm("Motivo de desactivacion");
            desactive.btnAceptar.Click += new EventHandler(desactivarproducto);
            desactive.textBox1.TextChanged += new EventHandler(metodo2);

            desactive.ShowDialog(this);


            
        }
        public void metodo2(object sender, EventArgs e)

        {

            MotivoCancelacion = ((TextBox)sender).Text;
        }

        public void desactivarproducto(object sender, EventArgs e)
        {
           
            MessageBox.Show(MotivoCancelacion);
           

        }
    }
}
