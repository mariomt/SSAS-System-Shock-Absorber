using Entities;
using System.Windows.Forms;

namespace Cliente
{
    public partial class HomeForm : Form
    {
        LoginForm loginForm = null;
        User currentUser = null;
        public HomeForm(LoginForm loginForm,User user)
        {
            this.loginForm = loginForm;
            this.currentUser = user;
            InitializeComponent();
            this.label1.Text=$"Hola {user.Correo}";
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible)
                loginForm.Close();
        }
    }
}
