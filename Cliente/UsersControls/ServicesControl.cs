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
                    Tools.Alert("Servicio guardado con éxito!", Form_Alert.enumType.Success);
                    clearTextBox();
                    loadDataGridView();
                }
                else
                    Tools.Alert("Ups! Algo salio mal.", Form_Alert.enumType.Success);
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
    }
}
