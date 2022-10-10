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
    public partial class Informatico : Form
    {
        public Informatico()
        {
            InitializeComponent();
        }

        private void btndirectivo_Click(object sender, EventArgs e)
        {
                this.Hide();
                ABMCuerpoDirectivo frm = new ABMCuerpoDirectivo();
                frm.Show();
        }

        private void btnadministracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMAdministracion frm = new ABMAdministracion();
            frm.Show();
        }
    }
}
