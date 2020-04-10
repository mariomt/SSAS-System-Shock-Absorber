using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum enumType
        {
            Success,
            Warning,
            Info,
            Error
        }

        public enum enumAction
        {
            wait,
            start,
            close
        }

        private Form_Alert.enumAction action;

        private int x, y;

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.action = enumAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    this.timer1.Interval = 5000;
                    this.action = enumAction.close;
                    break;
                case enumAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    } else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left += 3;

                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enumType type)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Opacity = 0.0;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enumType.Success:
                    this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    iconPictureBox1.BackColor = Color.SeaGreen;
                    iconPictureBox2.BackColor = Color.SeaGreen;
                    this.BackColor = Color.SeaGreen;
                    break;

                case enumType.Info:
                    this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                    iconPictureBox1.BackColor = Color.RoyalBlue;
                    iconPictureBox2.BackColor = Color.RoyalBlue;
                    this.BackColor = Color.RoyalBlue;
                    break;

                case enumType.Warning:
                    this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    iconPictureBox1.BackColor = Color.DarkOrange;
                    iconPictureBox2.BackColor = Color.DarkOrange;
                    this.BackColor = Color.DarkOrange;
                    break;

                case enumType.Error:
                    this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Frown;
                    iconPictureBox1.BackColor = Color.DarkRed;
                    iconPictureBox2.BackColor = Color.DarkRed;
                    this.BackColor = Color.DarkRed;
                    break;
            }


            this.label1.Text = msg;
            this.Show();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
