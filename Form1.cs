﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total = 0;
            total = ComputingLogic.plus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float total = 0;
            total = ComputingLogic.minus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float total = 0;
            total = ComputingLogic.multiply(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = total.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            float total = 0;
            if (Convert.ToInt32(textBox2.Text) !=0)
            {
                total = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = total.ToString();
            }


            label1.Text="Nelze delit nulou";
        }
    }
}
