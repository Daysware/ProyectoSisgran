using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class CargasyAsociaciones : Form
    {
        public CargasyAsociaciones()
        {
            InitializeComponent();
        }

        private void txtasosiaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcargas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuertaEcologica frm = new HuertaEcologica();
            frm.Show();
        }
    }
}
