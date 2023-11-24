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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal alturaarea = Convert.ToDecimal(textaltarea.Text);
            decimal larguraarea = Convert.ToDecimal(textlargarea.Text);

            decimal resultarea = alturaarea * larguraarea;

            labelresultarea.Text = resultarea.ToString();
        }

        private void btnvolume_Click(object sender, EventArgs e)
        {
            decimal alturavolume = Convert.ToDecimal(textaltvolume.Text);
            decimal larguravolume = Convert.ToDecimal(textlarvolume.Text);
            decimal comprimentovolume = Convert.ToDecimal(textcompvolume.Text);

            decimal resultvolume = alturavolume * larguravolume * comprimentovolume;

            labelresultvolume.Text = resultvolume.ToString();
        }
    }
}
