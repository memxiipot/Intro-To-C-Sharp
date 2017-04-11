using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digit_Reversal_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, numR;
            int a, b, c;
            int temp;
            num = int.Parse(t1.Text);
            c = num % 10;   //Get the remainder
            temp = num / 10;
            a = temp / 10;
            b = temp % 10;
            numR = (c * 100) + (b * 10) + (a * 1);
            t2.Text = numR.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num, numR;
            string a, b, c;
            num = t1.Text;
            a = num[0].ToString();
            b = num[1].ToString();
            c = num[2].ToString();
            numR = c + b + a;
            t2.Text = numR;
        }
    }
}
