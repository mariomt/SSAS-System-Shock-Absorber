namespace Cliente.UsersControls
{
    partial class BatchesControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productoLbl = new System.Windows.Forms.Label();
            this.ProductoCb = new System.Windows.Forms.ComboBox();
            this.importeLbl = new System.Windows.Forms.Label();
            this.importeTxt = new System.Windows.Forms.TextBox();
            this.Cantidadlbl = new System.Windows.Forms.Label();
            this.cantidadTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activoChk = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.dgvBatches = new System.Windows.Forms.DataGridView();
            this.LoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesactive = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.productoLbl);
            this.flowLayoutPanel1.Controls.Add(this.ProductoCb);
            this.flowLayoutPanel1.Controls.Add(this.importeLbl);
            this.flowLayoutPanel1.Controls.Add(this.importeTxt);
            this.flowLayoutPanel1.Controls.Add(this.Cantidadlbl);
            this.flowLayoutPanel1.Controls.Add(this.cantidadTxt);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.cancelBtn);
            this.flowLayoutPanel1.Controls.Add(this.agregarBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 314);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // productoLbl
            // 
            this.productoLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productoLbl.AutoSize = true;
            this.productoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLbl.Location = new System.Drawing.Point(13, 10);
            this.productoLbl.Name = "productoLbl";
            this.productoLbl.Size = new System.Drawing.Size(77, 20);
            this.productoLbl.TabIndex = 0;
            this.productoLbl.Text = "Producto:";
            // 
            // ProductoCb
            // 
            this.ProductoCb.FormattingEnabled = true;
            this.ProductoCb.Location = new System.Drawing.Point(13, 33);
            this.ProductoCb.Name = "ProductoCb";
            this.ProductoCb.Size = new System.Drawing.Size(293, 21);
            this.ProductoCb.TabIndex = 13;
            this.ProductoCb.SelectedIndexChanged += new System.EventHandler(this.ProductoCb_SelectedIndexChanged);
            // 
            // importeLbl
            // 
            this.importeLbl.AutoSize = true;
            this.importeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeLbl.Location = new System.Drawing.Point(13, 57);
            this.importeLbl.Name = "importeLbl";
            this.importeLbl.Size = new System.Drawing.Size(68, 20);
            this.importeLbl.TabIndex = 4;
            this.importeLbl.Text = "Importe:";
            // 
            // importeTxt
            // 
            this.importeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTxt.Location = new System.Drawing.Point(13, 80);
            this.importeTxt.Name = "importeTxt";
            this.importeTxt.Size = new System.Drawing.Size(293, 22);
            this.importeTxt.TabIndex = 5;
            // 
            // Cantidadlbl
            // 
            this.Cantidadlbl.AutoSize = true;
            this.Cantidadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidadlbl.Location = new System.Drawing.Point(13, 105);
            this.Cantidadlbl.Name = "Cantidadlbl";
            this.Cantidadlbl.Size = new System.Drawing.Size(77, 20);
            this.Cantidadlbl.TabIndex = 2;
            this.Cantidadlbl.Text = "Cantidad:";
            // 
            // cantidadTxt
            // 
            this.cantidadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTxt.Location = new System.Drawing.Point(13, 128);
            this.cantidadTxt.Name = "cantidadTxt";
            this.cantidadTxt.Size = new System.Drawing.Size(293, 22);
            this.cantidadTxt.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.activoChk);
            this.panel1.Location = new System.Drawing.Point(13, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 46);
            this.panel1.TabIndex = 12;
            // 
            // activoChk
            // 
            this.activoChk.AutoSize = true;
            this.activoChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activoChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoChk.Location = new System.Drawing.Point(3, 11);
            this.activoChk.Name = "activoChk";
            this.activoChk.Size = new System.Drawing.Size(71, 24);
            this.activoChk.TabIndex = 9;
            this.activoChk.Text = "Activo";
            this.activoChk.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Orange;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Location = new System.Drawing.Point(13, 208);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(143, 32);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.ForeColor = System.Drawing.Color.White;
            this.agregarBtn.Location = new System.Drawing.Point(162, 208);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(143, 32);
            this.agregarBtn.TabIndex = 11;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatches.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoteID,
            this.ProductoID,
            this.FechaHora,
            this.Importe,
            this.Cantidad,
            this.Activo});
            this.dgvBatches.GridColor = System.Drawing.Color.White;
            this.dgvBatches.Location = new System.Drawing.Point(346, 135);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatches.Size = new System.Drawing.Size(470, 314);
            this.dgvBatches.TabIndex = 12;
            this.dgvBatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatches_CellContentClick);
            // 
            // LoteID
            // 
            this.LoteID.HeaderText = "LoteID";
            this.LoteID.Name = "LoteID";
            this.LoteID.ReadOnly = true;
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // btnDesactive
            // 
            this.btnDesactive.BackColor = System.Drawing.Color.DarkRed;
            this.btnDesactive.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDesactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesactive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDesactive.IconColor = System.Drawing.Color.Black;
            this.btnDesactive.IconSize = 16;
            this.btnDesactive.Location = new System.Drawing.Point(729, 105);
            this.btnDesactive.Name = "btnDesactive";
            this.btnDesactive.Rotation = 0D;
            this.btnDesactive.Size = new System.Drawing.Size(87, 27);
            this.btnDesactive.TabIndex = 13;
            this.btnDesactive.Text = "Desactivar";
            this.btnDesactive.UseVisualStyleBackColor = false;
            this.btnDesactive.Click += new System.EventHandler(this.btnDesactive_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(639, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(87, 27);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(346, 109);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(290, 20);
            this.txtBuscar.TabIndex = 15;
            // 
            // BatchesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDesactive);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BatchesControl";
            this.Size = new System.Drawing.Size(819, 491);
            this.Load += new System.EventHandler(this.BatchesControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productoLbl;
        private System.Windows.Forms.Label importeLbl;
        private System.Windows.Forms.TextBox importeTxt;
        private System.Windows.Forms.Label Cantidadlbl;
        private System.Windows.Forms.TextBox cantidadTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox activoChk;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.ComboBox ProductoCb;
        private System.Windows.Forms.DataGridView dgvBatches;
        private FontAwesome.Sharp.IconButton btnDesactive;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
