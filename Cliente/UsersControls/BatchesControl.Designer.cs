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
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // BatchesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BatchesControl";
            this.Size = new System.Drawing.Size(819, 491);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
