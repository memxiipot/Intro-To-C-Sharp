using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_3_digit_Digit_Reversal_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int origNum;
            int temp;
            int f;
            int s;
            int m;
            int rev;
            origNum = int.Parse(input.Text);
            temp = (origNum / 10);
            f = (origNum % 10);
            s = (temp / 10);
            m = (temp % 10);
            f = (f * 100);
            m = (m * 10);
            s = (s * 1);
            rev = (f + m + s);
            output.Text = rev.ToString(); ;


        }
        
        private void label9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
