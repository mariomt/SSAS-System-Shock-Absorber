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
    public partial class InputForm : Form
    {
        public InputForm(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
