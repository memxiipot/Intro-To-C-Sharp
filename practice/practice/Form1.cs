using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;  //counter
            char input = char.Parse(tb1.Text);  //input letter to be countned
            for (int x = 0; x <= tb3.Text.Length - 1; x++)  //length of word
            {
                char b = tb3.Text[x]; //scan per letter
                

                if (b == input)
                {
                    total++;
                }

            }

            tb2.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = t1.Text;
            for (int index = 0; index <= name.Length; index++)
            {
                t2.Text = index.ToString();
            }



            //opposite
            //String name = t1.Text;
            //String y = "";
            //for (int a = name.Length - 1; a >= 0; a--)
            //{
            //    y = y + name.Substring(a, 1);
            //}

            //t2.Text = y.ToString();


        }


    }
}
