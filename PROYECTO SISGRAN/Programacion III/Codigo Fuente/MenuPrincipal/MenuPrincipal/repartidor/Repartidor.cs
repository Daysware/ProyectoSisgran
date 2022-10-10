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
    public partial class Repartidor : Form
    {
        public Repartidor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpedidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtseleccionar_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelnombre_Click(object sender, EventArgs e)
        {

        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int estado;
            try
            {
               estado = Int32.Parse(txtestado.Text);
                if (estado == 7)
                {
                    MessageBox.Show("ok");
                }
                else {
                    MessageBox.Show("debe ser el estado de pedido '7'(entregado)");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ser un numero entre 1 y 7");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnaceptar.Visible = true;
            labelnombre.Visible = true;
            txtnombrecliente.Visible = true;
            labelpedido.Visible = true;
            txtestado.Visible = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtestado.Text = ("");
            txtnombrecliente.Text = ("");
            txtseleccionar.Text = ("");
            btnaceptar.Visible = false;
            labelnombre.Visible = false;
            txtnombrecliente.Visible = false;
            labelpedido.Visible = false;
            txtestado.Visible = false;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Repartidor_Load(object sender, EventArgs e)
        {

        }
    }
}
