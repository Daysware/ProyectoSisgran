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
    public partial class Manejodehe : Form
    {
        public Manejodehe()
        {
            InitializeComponent();
        }

        private void txthuerta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtproduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            administración frm = new administración();
            frm.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txthuerta.Text = ("");
            txtproduccion.Text = ("");
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txthuerta.Text);
                Int32.Parse(txtproduccion.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ser un numero");
            }
        }
    }
}
