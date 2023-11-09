using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNmr1.Text) + float.Parse(txtNmr2.Text)).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNmr1.Text) - float.Parse(txtNmr2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNmr1.Text) * float.Parse(txtNmr2.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNmr1.Text) / float.Parse(txtNmr2.Text)).ToString();
        }
    }
}
