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
    public partial class ABMcliente : Form
    {
        public ABMcliente()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtmodcelular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radiomodautorizado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiomodnoautorizado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtmodemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtesquina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiomodempresa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiomodterminal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtmodterminal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmodnombreempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                long.Parse(txtmodcelular.Text);
                Int32.Parse(txtnumero.Text);
                Int32.Parse(txtmodterminal.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ser un numero");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtmodcelular.Text = ("");
            txtmodemail.Text = ("");
            txtcalle.Text = ("");
            txtnumero.Text = ("");
            txtesquina.Text = ("");
            txtbarrio.Text = ("");
            txtmodterminal.Text = ("");
            txtmodnombreempresa.Text = ("");
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            infocliente frm = new infocliente();
            frm.Show();
        }
    }
}
