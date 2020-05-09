using System;
using System.Windows.Forms;

namespace Cliente.UsersControls
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            dataGridView1.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            flowLayoutPanel1.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            txtSearch.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
            txtTotal.KeyDown += new KeyEventHandler(SalesControl_KeyDown);
        }

        private void consultaProductoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi mensaje");
        }

        private void SalesControl_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.Control && e.KeyCode == Keys.F2)
            {
                consultaProductoBtn_Click(this, e);
            }
        }

        
    }
}
