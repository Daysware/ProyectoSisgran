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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtlogin.Text = ("");
            txtcontraseña.Text = ("");

        }

        
       

        private void btningresar_Click(object sender, EventArgs e)
        {
            String login = txtlogin.Text;
            String pass = txtcontraseña.Text;
            if (login==("admin") && pass==("admin")) {
                this.Hide();
                administración frm = new administración();
                frm.Show();
            }
            else if (login == ("huerta") && pass == ("huerta")) {
                this.Hide();
                HuertaEcologica frm = new HuertaEcologica();
                frm.Show();
            }
            else if (login == ("repartidor") && pass == ("repartidor"))
            {
                this.Hide();
                Repartidor frm = new Repartidor();
                frm.Show();
            }
            else if (login == ("inform") && pass == ("inform"))
            {
                this.Hide();
                Informatico frm = new Informatico();
                frm.Show();
            }
            else if (login == ("direct") && pass == ("direct"))
            {
                this.Hide();
                CuerpoDirectivo frm = new CuerpoDirectivo();
                frm.Show();
            }
            else if (login == ("cliente") && pass == ("cliente"))
            {
                this.Hide();
                RealizarPedido frm = new RealizarPedido();
                frm.Show();
            }
        }
    }
}
