﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();

            form2.Closed += (s, args) => this.Show();

            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();

            form3.Closed += (s, args) => this.Show();

            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();

            form4.Closed += (s, args) => this.Show();

            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();

            form8.Closed += (s, args) => this.Show();

            form8.ShowDialog();


        }
    }
}
