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

            lb1.Items.Clear();
            int a = 12;
            while (a <= 120)
            {
                lb1.Items.Add(a);
                a += 12;
            }

            //FOR LOOPS

            //for (int a = 12; a <= 120; a += 12)
            //{
            //    lb1.Items.Add(a);
            //}
            
        }

        private void b2_Click(object sender, EventArgs e)
        {

            lb2.Items.Clear();
            int i = 1;
            while (i <= 256)
            {
                lb2.Items.Add(i);
                i += i;
            }

            //FOR LOOPS

            //Version 1
            //for (int i = 1; i <= 256; i += i)
            //{
            //    lb2.Items.Add(i);
            //}
                        
            //Version 2
            //for (int i = 1; i <= 256; i *= 2)
            //{
            //    lb3.Items.Add(i);     
            //}

        }

        private void b3_Click(object sender, EventArgs e)
        {
            
            lb3.Items.Clear();
            int a = 200;
            while (a >= 100)
            {
                lb3.Items.Add(a);
                a--;
            }

            //FOR LOOPS

            //for (int a = 200; a >= 100; a--)
            //{
            //    lb3.Items.Add(a);
            //}

        }

        private void b4_Click(object sender, EventArgs e)
        {
                        
            float avg = 0.0f;
            int a = 1;
            while (a <= 100)
            {
                avg += a;
                a++;
            }
            avg /= 100.0f;
            tb.Text = avg.ToString();

            //for (int a = 1; a <= 100; a++)
            //{
            //    avg += a;
            //}

            //avg /= 100.0f;
            //tb.Text = avg.ToString();
            
        }
    }
}
