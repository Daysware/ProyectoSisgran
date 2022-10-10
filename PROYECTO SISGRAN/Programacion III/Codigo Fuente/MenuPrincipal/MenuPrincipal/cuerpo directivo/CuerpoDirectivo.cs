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
    public partial class CuerpoDirectivo : Form
    {
        public CuerpoDirectivo()
        {
            InitializeComponent();
        }

        private void btnavance_Click(object sender, EventArgs e)
        {
             this.Hide();
             AvancePedidos frm = new AvancePedidos();
             frm.Show();
        }

        private void btnproduccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProduccionHuerta frm = new ProduccionHuerta();
            frm.Show();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
