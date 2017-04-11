using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11_25_13_ISPROG1LoopsLongQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            
            for (int a = 12; a <= 120; a += 12)
            {
                lb1.Items.Add(a);
            }
            
        }

        private void b2_Click(object sender, EventArgs e)
        {

            lb3.Items.Clear();

            //Version 1
            for (int i = 1; i <= 256; i += i)
            {
                lb2.Items.Add(i);
            }
                        
            //Version 2
            //for (int i = 1; i <= 256; i *= 2)
            //{
            //    lb3.Items.Add(i);     
            //}

        }

        private void b3_Click(object sender, EventArgs e)
        {
            
            for (int a = 200; a >= 100; a--)
            {
                lb3.Items.Add(a);
            }

        }

        private void b4_Click(object sender, EventArgs e)
        {
            
            float avg = 0.0f;

            for (int a = 1; a <= 100; a++)
            {
                avg += a;
            }

            avg /= 100.0f;
            tb.Text = avg.ToString();
            
        }
    }
}
