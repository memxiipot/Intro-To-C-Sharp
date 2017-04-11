using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compute_Sum_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1;
            float num2;
            float num3;
            float numSum;
            num1 = float.Parse(t1.Text);
            num2 = float.Parse(t2.Text);
            num3 = float.Parse(t3.Text);
            numSum = num1 + num2 + num3;
            tS.Text = numSum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
