using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LongQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PROBLEM A
            lb1.Items.Clear();

            for (int x = 1001; x <= 2000; x++)

            lb1.Items.Add(x);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PROBLEM B
            lb2.Items.Clear();
            int y = int.Parse(tb1.Text);

            for (int x = 2001; x <= y; x++)
                lb2.Items.Add(x);

            //for (int x = 2001; x >= y; x--)
            //    lb2.Items.Add(x);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PROBLEM C
            lb3.Items.Clear();
            int a = int.Parse(tb2.Text);
            int b = int.Parse(tb3.Text);

            for (int x = a; x <= b; x++)

            lb3.Items.Add(x);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //PROBLEM D
            lb4.Items.Clear();
            int a = int.Parse(tb4.Text);
            int b = int.Parse(tb5.Text);

            for (int x = a; x >= b; x--)

            lb4.Items.Add(x);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //PROBLEM E
            lb5.Items.Clear();
            for (float x = 1; x <= 100;  x += 0.25f)
                lb5.Items.Add(x);

        }





    }
}
