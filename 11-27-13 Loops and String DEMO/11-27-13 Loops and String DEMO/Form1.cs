using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11_27_13_Loops_and_String_DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //display word one letter at a time
            for (int i = 0; i <= t1.Text.Length - 1; i++)
            {
                char c = t1.Text[i];
                MessageBox.Show(c.ToString());
            }

            //int a = 0;
            //while (a <= t1.Text.Length -1)
            //{
            //    char c = t1.Text[i];
            //    MessageBox.Show(c.ToString());
            //    a++;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //input letter
            int totalI = 0;
            char input = char.Parse(t4.Text);
            for (int i = 0; i <= t2.Text.Length - 1; i++)
            {
                char c = t2.Text[i];
                if (c == input)
                {
                    totalI++;
                }
            }
            
            t3.Text = totalI.ToString();

            //
            //int totalI = 0;
            //for (int i = 0; i <= t2.Text.Length - 1; i++)
            //{

            //}

        }


    }
}
