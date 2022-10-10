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
    public partial class infocliente : Form
    {
        public infocliente()
        {
            InitializeComponent();
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioautorizado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radionoautorizado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioempresa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioterminal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtterminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombreempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMcliente frm = new ABMcliente();
            frm.Show();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            administración frm = new administración();
            frm.Show();
        }
    }
}
