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
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int count = 0;

            int i = a;
            while (i < b)
            //for (int i = a; i <= b; )
            {
                
                lb.Items.Add(i);
                

                if (i < b)
                {
                    count++;
                }

                tb3.Text = count.ToString();
            }

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
