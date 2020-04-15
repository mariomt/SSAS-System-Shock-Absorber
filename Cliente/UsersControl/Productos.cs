using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class UserProductos : UserControl
    {
        public UserProductos()
        {
            InitializeComponent();
        }

        private void UserProductos_Load(object sender, EventArgs e)
        {
            cargardgv();
        }
        private void cargardgv()
        {

        }
    }
}
