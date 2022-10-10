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
    public partial class BMCuerpoDirectivo : Form
    {
        public BMCuerpoDirectivo()
        {
            InitializeComponent();
        }

        private void txtnombremiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtloginmiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtañomiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbaja_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txtañomiembro.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ser un año");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMCuerpoDirectivo frm = new ABMCuerpoDirectivo();
            frm.Show();
        }
    }
}
