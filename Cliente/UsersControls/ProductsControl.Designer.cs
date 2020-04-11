namespace Cliente
{
    partial class ProductsControl
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
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.preciolbl = new System.Windows.Forms.Label();
            this.disponibilidadTxt = new System.Windows.Forms.TextBox();
            this.disponibilidadLbl = new System.Windows.Forms.Label();
            this.IVATxt = new System.Windows.Forms.TextBox();
            this.IVALbl = new System.Windows.Forms.Label();
            this.activoChk = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.Location = new System.Drawing.Point(13, 10);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(188, 20);
            this.descripcionLbl.TabIndex = 0;
            this.descripcionLbl.Text = "Descripción del producto:";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descripcionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTxt.Location = new System.Drawing.Point(13, 33);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(293, 22);
            this.descripcionTxt.TabIndex = 1;
            this.descripcionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcionTxt_KeyDown);
            // 
            // precioTxt
            // 
            this.precioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.Location = new System.Drawing.Point(13, 177);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(293, 22);
            this.precioTxt.TabIndex = 3;
            this.precioTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioTxt_KeyDown);
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciolbl.Location = new System.Drawing.Point(13, 154);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(122, 20);
            this.preciolbl.TabIndex = 2;
            this.preciolbl.Text = "Precio de venta:";
            // 
            // disponibilidadTxt
            // 
            this.disponibilidadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibilidadTxt.Location = new System.Drawing.Point(13, 129);
            this.disponibilidadTxt.Name = "disponibilidadTxt";
            this.disponibilidadTxt.Size = new System.Drawing.Size(293, 22);
            this.disponibilidadTxt.TabIndex = 5;
            this.disponibilidadTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.disponibilidadTxt_KeyDown);
            // 
            // disponibilidadLbl
            // 
            this.disponibilidadLbl.AutoSize = true;
            this.disponibilidadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibilidadLbl.Location = new System.Drawing.Point(13, 106);
            this.disponibilidadLbl.Name = "disponibilidadLbl";
            this.disponibilidadLbl.Size = new System.Drawing.Size(111, 20);
            this.disponibilidadLbl.TabIndex = 4;
            this.disponibilidadLbl.Text = "Disponibilidad:";
            // 
            // IVATxt
            // 
            this.IVATxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVATxt.Location = new System.Drawing.Point(13, 81);
            this.IVATxt.Name = "IVATxt";
            this.IVATxt.Size = new System.Drawing.Size(293, 22);
            this.IVATxt.TabIndex = 7;
            this.IVATxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IVATxt_KeyDown);
            // 
            // IVALbl
            // 
            this.IVALbl.AutoSize = true;
            this.IVALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVALbl.Location = new System.Drawing.Point(13, 58);
            this.IVALbl.Name = "IVALbl";
            this.IVALbl.Size = new System.Drawing.Size(40, 20);
            this.IVALbl.TabIndex = 6;
            this.IVALbl.Text = "IVA:";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.descripcionLbl);
            this.flowLayoutPanel1.Controls.Add(this.descripcionTxt);
            this.flowLayoutPanel1.Controls.Add(this.IVALbl);
            this.flowLayoutPanel1.Controls.Add(this.IVATxt);
            this.flowLayoutPanel1.Controls.Add(this.disponibilidadLbl);
            this.flowLayoutPanel1.Controls.Add(this.disponibilidadTxt);
            this.flowLayoutPanel1.Controls.Add(this.preciolbl);
            this.flowLayoutPanel1.Controls.Add(this.precioTxt);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 314);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(162, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(13, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.activoChk);
            this.panel1.Location = new System.Drawing.Point(13, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 46);
            this.panel1.TabIndex = 12;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(819, 491);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.Label preciolbl;
        private System.Windows.Forms.TextBox disponibilidadTxt;
        private System.Windows.Forms.Label disponibilidadLbl;
        private System.Windows.Forms.TextBox IVATxt;
        private System.Windows.Forms.Label IVALbl;
        private System.Windows.Forms.CheckBox activoChk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}
