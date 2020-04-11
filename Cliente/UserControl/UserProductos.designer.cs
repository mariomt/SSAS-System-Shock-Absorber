namespace Cliente
{
    partial class UserProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtDisponibilidad = new System.Windows.Forms.MaskedTextBox();
            this.txtIVA = new System.Windows.Forms.MaskedTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Descripcion,
            this.PrecioVenta,
            this.Disponibilidad,
            this.IVA,
            this.Activo});
            this.dgvProductos.Location = new System.Drawing.Point(328, 85);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(488, 361);
            this.dgvProductos.TabIndex = 0;
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(3, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(322, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(3, 203);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(322, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(3, 265);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(145, 20);
            this.txtDisponibilidad.TabIndex = 3;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(0, 351);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(138, 20);
            this.txtIVA.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 106);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(3, 187);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(12, 249);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(72, 13);
            this.lblDisponibilidad.TabIndex = 8;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(3, 335);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 10;
            this.lblIVA.Text = "IVA";
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(331, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(326, 20);
            this.txtBuscar.TabIndex = 14;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(328, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(688, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(366, 455);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(477, 455);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(75, 23);
            this.btnDesactivar.TabIndex = 18;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // UserProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dgvProductos);
            this.MaximumSize = new System.Drawing.Size(819, 491);
            this.Name = "UserProductos";
            this.Size = new System.Drawing.Size(819, 491);
            this.Load += new System.EventHandler(this.UserProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtDisponibilidad;
        private System.Windows.Forms.MaskedTextBox txtIVA;
        public System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}
