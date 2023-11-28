using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConstrutores
{
    public partial class Form3 : Form
    {
        decimal areaTijolo = 741;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            areaTijolo = 741;
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioceramico_CheckedChanged(object sender, EventArgs e)
        {
            areaTijolo = 551;
        }

        private void radiobaiano_CheckedChanged(object sender, EventArgs e)
        {
            areaTijolo = 551;
        }

        private void radiobarro_CheckedChanged(object sender, EventArgs e)
        {
            areaTijolo = 105;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            areaTijolo = Convert.ToDecimal(textB.Text) * Convert.ToDecimal(textC.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal altura = Convert.ToDecimal(textaltura.Text);
            decimal largura = Convert.ToDecimal(textlargura.Text);
            decimal area = altura * largura;


            string result = Convert.ToString(Math.Round(1.05m * (area / areaTijolo)) );
            resultado.Text = String.Format("Para " +area+ " m² será necessário " + result + " unidades");
        }
    }
}
