using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf013, 0);
        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf013, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Clear();
            iconPictureBox2.IconColor = Color.FromArgb(121, 175, 249);
            txtUser.ForeColor = Color.FromArgb(121, 175, 249);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0)
            {
                txtUser.Text = "NombreDeUsuario";
                iconPictureBox2.IconColor = SystemColors.ButtonShadow;
            }
            else
            {
                iconPictureBox2.IconColor = Color.White;
            }
            txtUser.ForeColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            iconPictureBox3.IconColor = Color.FromArgb(121, 175, 249);
            txtPassword.ForeColor = Color.FromArgb(121, 175, 249);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Mi contraseña";
                iconPictureBox3.IconColor = SystemColors.ButtonShadow;
            }
            else
            {
                iconPictureBox3.IconColor = Color.White;
            }

            txtPassword.ForeColor = Color.White;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                NombreUsuario = txtUser.Text.ToLower(),
                Contrasena = txtPassword.Text
            };

            if(new UserDomain().logIn(ref user))
            {
                MainInformation.user = user;
                HomeForm hf1 = new HomeForm(this, user);
                iconButton1.Focus();
                txtPassword.Text = "";
                txtPassword_Leave(iconButton1,e);
                txtUser.Text = "";
                txtUser_Leave(iconButton1,e);
                hf1.Show();
                this.Hide();
            }else
            {
                lblError.Text = "Usuario y/o contraseña incorrectos.";
                lblError.Visible = true;
            }
        }
    }
}
