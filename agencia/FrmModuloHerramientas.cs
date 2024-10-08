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
    public partial class FrmModuloHerramientas : Form
    {
        public FrmModuloHerramientas()
        {
            InitializeComponent();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            FrmHerraminetas frmHerraminetas

                = new FrmHerraminetas();
            frmHerraminetas.Show();
        }

        private void lblherrm_Click(object sender, EventArgs e)
        {

        }

        private void txtHerra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvHerramientas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
