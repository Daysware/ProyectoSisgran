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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }

        private void Produccion_Load(object sender, EventArgs e)
        {

        }

        private void txtcultivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuertaEcologica frm = new HuertaEcologica();
            frm.Show();
        }
    }
}
