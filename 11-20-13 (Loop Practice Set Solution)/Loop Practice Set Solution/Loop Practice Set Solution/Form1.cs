using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loop_Practice_Set_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            //Get input a and b
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            //Version 2
            if (a % 2 != 0) a++;
            //For loop
            for (int i = a; i <= b; i += 2)
            {
                lb.Items.Add(i);
            }

            //Version 1
            //For Loop
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 2 == 0)
            //        lb.Items.Add(i);
            //}
            //While Loop
            //int i = a;
            //while (i <= b)
            //{
            //    if (i % 2 == 0)
            //    {
            //        lb.Items.Add(i);
            //    }
            //    i++;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int total = 0;
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {   //We've found an even number
                    total += i;
                    count++;
                }
            }
            lb.Items.Add("Total: " + total.ToString());
            lb.Items.Add("Even Count: " + count.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int total = 0;
            int count = 0;
            int b = 265;
            for (int a = 0; a <= b; a += 0)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {   //We've found an even number
                        total += i;
                        count++;
                    }
                }
            }

            lb.Items.Add("Total: " + total.ToString());
            lb.Items.Add("Even Count: " + count.ToString());

        }
    }
}
