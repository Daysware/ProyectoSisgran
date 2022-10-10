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
    public partial class ABMCuerpoDirectivo : Form
    {
        public ABMCuerpoDirectivo()
        {
            InitializeComponent();
        }

        private void txtcuerpodirectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BMCuerpoDirectivo frm = new BMCuerpoDirectivo();
            frm.Show();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informatico frm = new Informatico();
            frm.Show();
        }
    }
}
