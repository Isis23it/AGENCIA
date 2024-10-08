using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agencia
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            FrmProducto frmp = new FrmProducto();
            frmp.Show();
        }
    }
}
