using Cliente.UsersControls;
using Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cliente
{
    public partial class HomeForm : Form
    {
        LoginForm loginForm = null;
        User currentUser = null;
        UserControl activeControl = null;
        public HomeForm(LoginForm loginForm,User user)
        {
            this.loginForm = loginForm;
            this.currentUser = user;
            InitializeComponent();
            MainInformation.mainPanel = panelDesktop;
            //this.labelClose.Text=$"Hola {user.Correo}";
            lblUserName.Text = user.Nombre +" "+ user.ApellidoPaterno;
            lblRol.Text = user.rol.Descripcion;
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible)
                loginForm.Close();
        }

        private void iconPictureBox1_Click(object sender, System.EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Compress;
            }else
            {
                this.WindowState = FormWindowState.Normal;
                this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Expand;
            }
        }

        private void labelClose_Click(object sender, System.EventArgs e)
        {
            if (!loginForm.Visible)
                Application.Exit();
            else
                this.Close();
        }

        private void iconPictureBox2_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf013, 0);
        }


        private void openControl(UserControl control, string headerTitle = "Inicio")
        {

            panelLogoCentral.Visible = false;
            if(activeControl != null)
            {
                if (activeControl.GetType().Equals(control.GetType()))
                {
                    control.Dispose();
                    return;
                }
                this.panelDesktop.Controls.Remove(activeControl);
                activeControl.Dispose();
                activeControl = null;
            }
            control.Dock = DockStyle.Fill;
            control.AutoScroll = true;
            activeControl = control;
            this.panelDesktop.Controls.Add(activeControl);
            this.lblHeaderTitle.Text = headerTitle;
            activeControl.Show();
        }
        private void productsBtn_Click(object sender, System.EventArgs e)
        {
            openControl(new ProductsControl(),"Gestión de productos");
        }

        private void iconPictureBox3_Click(object sender, System.EventArgs e)
        {
            
        }

        private void iconDesactivar_Click(object sender, EventArgs e)
        {
            ProductsControl ProductosControl = new ProductsControl();
            ProductosControl.AutoScroll = true;
            this.panelDesktop.Controls.Add(ProductosControl);
            ProductosControl.Show();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            openControl(new ServicesControl(),"Gestión de servicios");
        }

        private void batchesBtn_Click(object sender, EventArgs e)
        {
            openControl(new BatchesControl(), "Gestión de lotes");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openControl(new ControlUsuarios(), "Gestión de usuarios");
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            openControl(new SalesControl(), "Registro de ventas");
            ((SalesControl)this.activeControl).txtSearch.Focus();
        }

        private void hourTimer_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToShortTimeString();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
