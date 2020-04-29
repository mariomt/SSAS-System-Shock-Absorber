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
            this.importeLbl = new System.Windows.Forms.Label();
            this.disponibilidadTxt = new System.Windows.Forms.TextBox();
            this.Cantidadlbl = new System.Windows.Forms.Label();
            this.cantidadTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activoChk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductoCb = new System.Windows.Forms.ComboBox();
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
            this.flowLayoutPanel1.Controls.Add(this.disponibilidadTxt);
            this.flowLayoutPanel1.Controls.Add(this.Cantidadlbl);
            this.flowLayoutPanel1.Controls.Add(this.cantidadTxt);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
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
            // disponibilidadTxt
            // 
            this.disponibilidadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibilidadTxt.Location = new System.Drawing.Point(13, 80);
            this.disponibilidadTxt.Name = "disponibilidadTxt";
            this.disponibilidadTxt.Size = new System.Drawing.Size(293, 22);
            this.disponibilidadTxt.TabIndex = 5;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(13, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(162, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ProductoCb
            // 
            this.ProductoCb.FormattingEnabled = true;
            this.ProductoCb.Location = new System.Drawing.Point(13, 33);
            this.ProductoCb.Name = "ProductoCb";
            this.ProductoCb.Size = new System.Drawing.Size(293, 21);
            this.ProductoCb.TabIndex = 13;
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
        private System.Windows.Forms.TextBox disponibilidadTxt;
        private System.Windows.Forms.Label Cantidadlbl;
        private System.Windows.Forms.TextBox cantidadTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox activoChk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ProductoCb;
    }
}
