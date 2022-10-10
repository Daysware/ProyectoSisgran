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
    public partial class HuertaEcologica : Form
    {
        public HuertaEcologica()
        {
            InitializeComponent();
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadoCultivo frm = new EstadoCultivo();
            frm.Show();
        }

        private void btncarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargasyAsociaciones frm = new CargasyAsociaciones();
            frm.Show();
        }

        private void btnproduccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produccion frm = new Produccion();
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
