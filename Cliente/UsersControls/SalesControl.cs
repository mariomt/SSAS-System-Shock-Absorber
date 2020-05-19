using Domain;
using Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cliente.UsersControls
{
    public partial class SalesControl : UserControl
    {
        Sale venta;
        bool isLoading = true;
        public SalesControl()
        {
            InitializeComponent();
            venta = new Sale();
            venta.usuario = MainInformation.user;
            dataGridView1.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            flowLayoutPanel1.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            txtSearch.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            txtTotal.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            isLoading = false;
        }

        private void consultaProductoBtn_Click(object sender, EventArgs e)
        {
            new ProductInfo().ShowDialog(this);
        }

        private void SalesControl_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.Control && e.KeyCode == Keys.F2)
            {
                consultaProductoBtn_Click(this, e);
            } else if (e.Control && e.KeyCode == Keys.S)
            {
                cobrarBtn_Click(this, e);
            }
        }

        /// <summary>
        /// Busca un producto o un servicio en la descripción de la venta y si existe este actualiza la cantidad y el importe del mismo.
        /// Si no se ha inicializado la descripción de la venta este método la inicializará.
        /// </summary>
        /// <param name="id">Id del producto o servicio</param>
        /// <param name="cant">Cantidad de productos que se agregarán</param>
        /// <param name="isProduct">Indica si el objecto a buscar es un producto, en caso contrario buscará un servicio</param>
        /// <returns>Devuelve true si encontro el producto agregado a la venta y devuelve false en caso contrario.</returns>
        public bool findInSaleDescription(int id, int cant, bool isProduct = true)
        {
            if (venta.descripcion == null)
            {
                venta.descripcion = new List<DescripcionVenta>();
            }
            else
            {
                int idx = isProduct? venta.descripcion.FindIndex(x => x.ProductoID == id) : venta.descripcion.FindIndex(x => x.ServicioID == id);
                if (idx >= 0)
                {
                    dataGridView1.Rows[idx].Cells[1].Value = venta.descripcion[idx].Cantidad + cant;
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Busca el producto y lo agrega al dgv y al objeto de venta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cant">Cantidad que se añade al carrito, por defecto es 1</param>
        private void addProduct(int id, int cant = 1)
        {

            if (findInSaleDescription(id, cant))
                return;

            Product producto = new ProductDomain().GetProductById(id);
            if (producto == null)
            {
                Tools.AlertInToApp("No se encontro el producto", Form_Alert.enumType.Error);
            }
            else
            {
                if (!producto.Activo)
                {
                    Tools.AlertInToApp("El producto no está activo!", Form_Alert.enumType.Info);
                    txtSearch.Focus();
                    return;
                }
                if(producto.Disponibilidad <= 0)
                {
                    Tools.AlertInToApp("Producto agotado!",Form_Alert.enumType.Info);
                    return;
                }

                if(producto.Disponibilidad < cant)
                {
                    DialogResult result = MessageBox.Show("Solo quedan " + producto.Disponibilidad + "productos disponibles. \n Desea agregarlos?","Diponibilidad",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;

                    cant = producto.Disponibilidad;
                }
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = producto.ProductoID;
                row.Cells[1].Value = cant;
                row.Cells[2].Value = producto.Descripcion;
                row.Cells[3].Value = producto.PrecioVenta;
                row.Cells[4].Value = producto.PrecioVenta*cant;
                row.Cells[5].Value = true;

                

                venta.descripcion.Add(new DescripcionVenta() {
                    ProductoID = producto.ProductoID,
                    Cantidad = cant,
                    PrecioUnitario = producto.PrecioVenta,
                    Cancelado = false
                }) ;

                updateTotal(producto.PrecioVenta * cant);
                dataGridView1.Rows.Add(row);
            }
        }

        /// <summary>
        /// Busca el servicio y lo agrega al dgv y al objecto de venta
        /// </summary>
        /// <param name="id"></param>
        private void addService(int id, int cant = 1)
        {
            if (findInSaleDescription(id, cant, false))
                return;

            Service servicio = new ServiceDomain().GetServiceById(id);
            if(servicio == null)
            {
                Tools.AlertInToApp("No se encontro el servicio", Form_Alert.enumType.Error);
            }
            else
            {

                if(!servicio.Activo)
                {
                    Tools.AlertInToApp("El servicio no está activo!", Form_Alert.enumType.Info);
                    txtSearch.Focus();
                    return;
                }
                string message = "";
                double price = 0;
                do
                {
                    message = ShowInput.ShowDialog(this, "Ingrese el precio del servicio:", "Precio de servicio", false);
                    if (message.Trim() == "cancelled")
                        break;

                    try
                    {
                        price = double.Parse(message);
                        if(price <= 0)
                        {
                            price = 0;
                            message = "";
                            Tools.AlertInToApp("La cantidad ingresada no puede ser menor o igual a cero", Form_Alert.enumType.Error);
                        }
                    }
                    catch (FormatException)
                    {
                        Tools.AlertInToApp("Asegurece de ingresar correctamente la cantidad", Form_Alert.enumType.Error);
                        message = "";
                    }

                } while (message.Trim().Length==0);


                if (message.Trim() == "cancelled")
                    return;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = servicio.ServicioID;
                row.Cells[1].Value = cant;
                row.Cells[2].Value = servicio.Descripcion;
                row.Cells[3].Value = price;
                row.Cells[4].Value = price * cant;
                row.Cells[5].Value = false;



                venta.descripcion.Add(new DescripcionVenta()
                {
                    ServicioID = servicio.ServicioID,
                    Cantidad = cant,
                    PrecioUnitario = price,
                    Cancelado = false
                });

                updateTotal(price * cant);
                dataGridView1.Rows.Add(row);

            }

        }
        /// <summary>
        /// Actualiza el total del texbox sumando el valor pasado en el parametro, para poder restar solo vasta con pasar el número en negativo.
        /// </summary>
        /// <param name="cant"></param>
        private void updateTotal(double cant)
        {
            double total = double.Parse(txtTotal.Text);
            total += cant;
            if (total == 0)
                txtTotal.Text = "00.00";
            else
                txtTotal.Text = total.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearch.Text.Trim().Length != 0)
                {
                    dynamic obj = arrayServiceProduct(txtSearch.Text.Trim().ToLower());
                    if (obj.isService)
                        addService(obj.id, obj.cantidad);
                    else
                        addProduct(obj.id, obj.cantidad);

                    e.Handled = true;
                    txtSearch.Text = string.Empty;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void clearSale()
        {
            txtTotal.Text = "00.00";
            dataGridView1.Rows.Clear();
            venta.descripcion.Clear();
            txtSearch.Focus();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {  
            if(e.ColumnIndex == 1)
            {
                if (!isLoading) 
                {
                    int value = int.Parse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if(value <= 0)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = venta.descripcion[e.RowIndex].Cantidad;
                        Tools.AlertInToApp("No se puede establecer una cantidad menor a 1", Form_Alert.enumType.Error);
                    }
                    else
                    {
                        updateTotal((value - venta.descripcion[e.RowIndex].Cantidad) * venta.descripcion[e.RowIndex].PrecioUnitario);
                        venta.descripcion[e.RowIndex].Cantidad = value;
                        dataGridView1[4, e.RowIndex].Value = value * venta.descripcion[e.RowIndex].PrecioUnitario;
                    }
                }
                isLoading = false;
            }

        }

     

        private void cobrarBtn_Click(object sender, EventArgs e)
        {
            if (venta.descripcion == null || venta.descripcion.Count == 0)
            {
                Tools.AlertInToApp("La venta no contiene elementos", Form_Alert.enumType.Error);
                txtSearch.Focus();
                return;
            }

            string message;
            double recibed = 0;
            double amount = double.Parse(txtTotal.Text.Trim());
            do
            {
                message = ShowInput.ShowDialog(this, "Cantidad recibida:", "Cobro de venta", false);
                if (message.Trim() == "cancelled")
                    break;

                try
                {
                    recibed = double.Parse(message);
                    if (recibed < amount)
                    {
                        recibed = 0;
                        message = "";
                        Tools.AlertInToApp("La cantidad ingresada no puede ser menor al Total.", Form_Alert.enumType.Error);
                    }
                }
                catch (FormatException)
                {
                    Tools.AlertInToApp("Asegurece de ingresar correctamente la cantidad", Form_Alert.enumType.Error);
                    message = "";
                }

            } while (message.Trim().Length == 0);

            if (message.Trim() == "cancelled")
            {
                txtSearch.Focus();
                return;
            }

            if (new saleDomain().insert(venta))
            {
                Tools.AlertInToApp("La venta se guardo con éxito", Form_Alert.enumType.Success);
                if (recibed > amount)
                    MessageBox.Show("Su cambio es: " + (recibed - amount));
                clearSale();
            }
            else
            {
                Tools.AlertInToApp("Algo salio mal en la venta intentalo de nuevo.", Form_Alert.enumType.Error);
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cancelar la venta?","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
                clearSale();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection index = dataGridView1.SelectedRows;
                DataGridViewRow selectedRow = index[0];
                int idx = selectedRow.Index;
                int qtty = int.Parse(selectedRow.Cells[1].Value.ToString());
                double amount = qtty * double.Parse(selectedRow.Cells[3].Value.ToString());

                dataGridView1.Rows.Remove(selectedRow);
                venta.descripcion.Remove(venta.descripcion[idx]);

                updateTotal(0 - amount);

            }
            catch (ArgumentOutOfRangeException)
            {
                Tools.AlertInToApp("No se seleccionó ningún registro", Form_Alert.enumType.Error);
            }
        }

        private object arrayServiceProduct(string ps)
        {

            Regex cantidadRegEx = new Regex(@"(^\d*\*)");
            Match cantidadMatch = cantidadRegEx.Match(ps);
            string cantidadStr = cantidadMatch.Groups[1].ToString();
            int cantidadInt = cantidadMatch.Success ? Int32.Parse(cantidadStr.Remove(cantidadStr.Length - 1)) : 1;

            Regex productIdRegEx = new Regex(@"\d*$");
            Match productIdMatch = productIdRegEx.Match(ps);
            int productId = Int32.Parse(productIdMatch.Groups[0].ToString());

            Regex serviceRegEx = new Regex(@"s");
            Match serviceMatch = serviceRegEx.Match(ps);
            bool esServicio = serviceMatch.Success;

            return new
            {
                cantidad = cantidadInt,
                id = productId,
                isService = esServicio
            };

        }
    }
}
