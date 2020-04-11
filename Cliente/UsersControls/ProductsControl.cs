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
    }
}
