﻿namespace Cliente
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelClose = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMenuContent = new System.Windows.Forms.Panel();
            this.productsBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
<<<<<<< HEAD
=======
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
>>>>>>> 193f4843febe3d89dcf6e5dccf055f3e4379c010
            this.panelSideMenu.SuspendLayout();
            this.panelMenuContent.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(786, 10);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(21, 20);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.panelSideMenu.Controls.Add(this.panelMenuContent);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(205, 580);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelMenuContent
            // 
            this.panelMenuContent.AutoScroll = true;
<<<<<<< HEAD
            this.panelMenuContent.Controls.Add(this.productsBtn);
=======
            this.panelMenuContent.Controls.Add(this.iconButton1);
>>>>>>> 193f4843febe3d89dcf6e5dccf055f3e4379c010
            this.panelMenuContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuContent.Location = new System.Drawing.Point(0, 89);
            this.panelMenuContent.Name = "panelMenuContent";
            this.panelMenuContent.Size = new System.Drawing.Size(205, 491);
            this.panelMenuContent.TabIndex = 1;
            // 
            // productsBtn
            // 
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.productsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.productsBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.productsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.productsBtn.IconSize = 24;
            this.productsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productsBtn.Location = new System.Drawing.Point(2, 2);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productsBtn.Rotation = 0D;
            this.productsBtn.Size = new System.Drawing.Size(201, 58);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Agregar Producto";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.iconPictureBox4);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(205, 89);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(78, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "SSAS";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.iconPictureBox4.IconSize = 64;
            this.iconPictureBox4.Location = new System.Drawing.Point(24, 26);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(64, 64);
            this.iconPictureBox4.TabIndex = 1;
            this.iconPictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox3);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 79);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRol.Location = new System.Drawing.Point(37, 32);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(58, 16);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Usuario:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(68, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 16);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.Location = new System.Drawing.Point(365, 31);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 3;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Location = new System.Drawing.Point(727, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(757, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(205, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 10);
            this.panel1.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(819, 491);
            this.panelDesktop.TabIndex = 4;
            // 
<<<<<<< HEAD
=======
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(205, 70);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Desactivar Producto";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
>>>>>>> 193f4843febe3d89dcf6e5dccf055f3e4379c010
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenuContent.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenuContent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
<<<<<<< HEAD
        private FontAwesome.Sharp.IconButton productsBtn;
=======
        private FontAwesome.Sharp.IconButton iconButton1;
>>>>>>> 193f4843febe3d89dcf6e5dccf055f3e4379c010
    }
}