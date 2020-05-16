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
using Entities;

namespace Cliente
{
    public partial class ServicesControl : UserControl 
    {
        private Service service = null;
        public ServicesControl()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ServicesControl_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView(string filter = null)
        {

            ServiceDomain serviceDomain = new ServiceDomain();
            IEnumerable<Service> servicios = null;
            if(filter==null)
            {
                servicios = serviceDomain.GetAll();
            }
            else
            {
                servicios = serviceDomain.SearchByName(filter);
            }

            dataGridView1.Rows.Clear();
            foreach (var servicio in servicios)
            {
                DataGridViewRow celda = new DataGridViewRow();
                celda.CreateCells(dataGridView1);
                celda.Cells[0].Value = servicio.ServicioID;
                celda.Cells[1].Value = servicio.Nombre;
                celda.Cells[2].Value = servicio.Descripcion;
                celda.Cells[3].Value = servicio.Activo;
                dataGridView1.Rows.Add(celda);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadDataGridView(txtSearch.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var service = new Service()
            {
                Nombre = txtName.Text,
                Descripcion = txtDescription.Text,
                Activo = chkActive.Checked
            };

            try
            {
                bool result = new ServiceDomain().insertNewProduct(service);
                if (result)
                {
                    Tools.AlertInToApp("Servicio guardado con éxito!", Form_Alert.enumType.Success);
                    clearTextBox();
                    loadDataGridView();
                }
                else
                    Tools.AlertInToApp("Ups! Algo salio mal.", Form_Alert.enumType.Success);
            }
            catch
            {
                Console.WriteLine("Ocurrio un error");
            }
        }

        private void clearTextBox()
        {
            txtName.Clear();
            txtDescription.Clear();
            chkActive.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Cancellation cancelar = new Cancellation(EnumTypeOperation.DisableService))
            {
                try
                {
                    DataGridViewSelectedRowCollection index = dataGridView1.SelectedRows;
                    DataGridViewRow row = index[0];
                    service = new Service()
                    {
                        ServicioID = (int)row.Cells[0].Value,
                        Nombre = row.Cells[1].Value.ToString(),
                        Descripcion = row.Cells[2].Value.ToString(),
                        Activo = (bool)row.Cells[3].Value
                    };

                    var bitacora = cancelar.showDialog(this);
                    if (bitacora != null)
                    {
                        service.Activo = false;
                        ServiceDomain svd = new ServiceDomain();
                        svd.disableService(service, bitacora);
                        Tools.AlertInToApp("El Servicio se desactivo con éxito.", Form_Alert.enumType.Success);
                        loadDataGridView();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Tools.AlertInToApp("No se selecciono nungun registro", Form_Alert.enumType.Error);
                }
                catch (ServiceDomainException err)
                {
                    Tools.AlertInToApp(err.Message, Form_Alert.enumType.Error);
                }
            }
                
        }

     


    }
}
