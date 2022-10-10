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
    public partial class BMAdministracion : Form
    {
        public BMAdministracion()
        {
            InitializeComponent();
        }

        private void BMAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void txtloginadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbaja_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMAdministracion frm = new ABMAdministracion();
            frm.Show();
        }
    }
}
