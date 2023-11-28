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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Concreto_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();

            form5.Closed += (s, args) => this.Show();

            form5.ShowDialog();
        }

        private void argamassa_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();

            form7.Closed += (s, args) => this.Show();

            form7.ShowDialog();
        }
    }
}