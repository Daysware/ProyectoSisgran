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
    public partial class RevisionDePedidos : Form
    {
        public RevisionDePedidos()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            administración frm = new administración();
            frm.Show();
        }

        private void numPedido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(numPedido.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ser un numero");
            }
        }
    }
}
