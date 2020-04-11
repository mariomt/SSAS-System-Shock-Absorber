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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Location = new System.Drawing.Point(3, 0);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(128, 13);
            this.descripcionLbl.TabIndex = 0;
            this.descripcionLbl.Text = "Descripción del producto:";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descripcionTxt.Location = new System.Drawing.Point(3, 16);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(245, 20);
            this.descripcionTxt.TabIndex = 1;
            this.descripcionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcionTxt_KeyDown);
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(3, 133);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(245, 20);
            this.precioTxt.TabIndex = 3;
            this.precioTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioTxt_KeyDown);
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.Location = new System.Drawing.Point(3, 117);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(85, 13);
            this.preciolbl.TabIndex = 2;
            this.preciolbl.Text = "Precio de venta:";
            // 
            // disponibilidadTxt
            // 
            this.disponibilidadTxt.Location = new System.Drawing.Point(3, 94);
            this.disponibilidadTxt.Name = "disponibilidadTxt";
            this.disponibilidadTxt.Size = new System.Drawing.Size(245, 20);
            this.disponibilidadTxt.TabIndex = 5;
            this.disponibilidadTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.disponibilidadTxt_KeyDown);
            // 
            // disponibilidadLbl
            // 
            this.disponibilidadLbl.AutoSize = true;
            this.disponibilidadLbl.Location = new System.Drawing.Point(3, 78);
            this.disponibilidadLbl.Name = "disponibilidadLbl";
            this.disponibilidadLbl.Size = new System.Drawing.Size(75, 13);
            this.disponibilidadLbl.TabIndex = 4;
            this.disponibilidadLbl.Text = "Disponibilidad:";
            // 
            // IVATxt
            // 
            this.IVATxt.Location = new System.Drawing.Point(3, 55);
            this.IVATxt.Name = "IVATxt";
            this.IVATxt.Size = new System.Drawing.Size(245, 20);
            this.IVATxt.TabIndex = 7;
            this.IVATxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IVATxt_KeyDown);
            // 
            // IVALbl
            // 
            this.IVALbl.AutoSize = true;
            this.IVALbl.Location = new System.Drawing.Point(3, 39);
            this.IVALbl.Name = "IVALbl";
            this.IVALbl.Size = new System.Drawing.Size(27, 13);
            this.IVALbl.TabIndex = 6;
            this.IVALbl.Text = "IVA:";
            // 
            // activoChk
            // 
            this.activoChk.AutoSize = true;
            this.activoChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activoChk.Location = new System.Drawing.Point(3, 159);
            this.activoChk.Name = "activoChk";
            this.activoChk.Size = new System.Drawing.Size(56, 17);
            this.activoChk.TabIndex = 9;
            this.activoChk.Text = "Activo";
            this.activoChk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.descripcionLbl);
            this.flowLayoutPanel1.Controls.Add(this.descripcionTxt);
            this.flowLayoutPanel1.Controls.Add(this.IVALbl);
            this.flowLayoutPanel1.Controls.Add(this.IVATxt);
            this.flowLayoutPanel1.Controls.Add(this.disponibilidadLbl);
            this.flowLayoutPanel1.Controls.Add(this.disponibilidadTxt);
            this.flowLayoutPanel1.Controls.Add(this.preciolbl);
            this.flowLayoutPanel1.Controls.Add(this.precioTxt);
            this.flowLayoutPanel1.Controls.Add(this.activoChk);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(261, 253);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(609, 259);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
    }
}
