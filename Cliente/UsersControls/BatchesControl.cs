﻿using System;
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
using Domain;

namespace Cliente.UsersControls
{
    public partial class BatchesControl : UserControl
    {
        Batch loteseleccionado;
        IDictionary<string, Regex> validationRegEx;
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
            cargardgvBatches();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cargardgvBatches()
        {
            dgvBatches.Rows.Clear();
            BatchDomain batch = new BatchDomain();
            var listalote = batch.getBatch();
            foreach (var lote in listalote)
            {
                DataGridViewRow celda = new DataGridViewRow();
                celda.CreateCells(dgvBatches);
                celda.Cells[0].Value = lote.LoteID;
                celda.Cells[1].Value = lote.ProductoID;
                celda.Cells[2].Value = lote.FechaHora;
                celda.Cells[3].Value = lote.Importe;
                celda.Cells[4].Value = lote.Cantidad;
                celda.Cells[5].Value = lote.Activo;
               dgvBatches.Rows.Add(celda);
            }

        }

        private void btnDesactive_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection index = dgvBatches.SelectedRows;
                DataGridViewRow selectedRow = index[0];
                loteseleccionado = new Batch();
                loteseleccionado.LoteID = (int)selectedRow.Cells[0].Value;
                loteseleccionado.ProductoID = (int)selectedRow.Cells[1].Value;
                loteseleccionado.FechaHora = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                loteseleccionado.Importe = double.Parse(selectedRow.Cells[3].Value.ToString());
                loteseleccionado.Cantidad = int.Parse(selectedRow.Cells[4].Value.ToString());
                loteseleccionado.Activo = (bool)selectedRow.Cells[5].Value;

                Cancellation desactivar = new Cancellation(EnumTypeOperation.DisableService);

                BitacoraOperaciones bitacoraOP = desactivar.showDialog(this);
                if (bitacoraOP != null)
                {
                    BatchDomain lote = new BatchDomain();
                    loteseleccionado.Activo = false;
                    if (lote.bajalote(loteseleccionado, bitacoraOP))
                    {
                        Tools.Alert("Se dio de baja el lote", Form_Alert.enumType.Success);
                         
                        cargardgvBatches();
                    }
                    else
                    {
                        Tools.Alert("Error al guardar la informacion", Form_Alert.enumType.Error);
                    }


                }
            }
            catch (Exception)
            {

                
            }
        }

        private void dgvBatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        }
    }

