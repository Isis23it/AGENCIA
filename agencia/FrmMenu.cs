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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void rEGISTROUSESRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEdicion frmEdicion = new FrmEdicion();
            frmEdicion.Show();
        }

        private void herraminetastool_Click(object sender, EventArgs e)
        {
            FrmModuloHerramientas frmHe = new FrmModuloHerramientas();
            frmHe.Show();
        }

        private void productostool_Click(object sender, EventArgs e)
        {
            FrmProductos frmp   = new FrmProductos();
            frmp.Show();
        }
    }
}
