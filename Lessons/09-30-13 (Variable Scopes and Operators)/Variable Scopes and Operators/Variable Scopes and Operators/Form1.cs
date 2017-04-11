using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variable_Scopes_and_Operators
{
    public partial class Form1 : Form
    {
        //Declare here
        public Form1()
        {
            InitializeComponent();
        }

        //Declare here
        private void button1_Click(object sender, EventArgs e)
        {
            {
                int x = 0;
            }

            string message = "Hello!";
            MessageBox.Show(message);
            MessageBox.Show(name);
        }

        //Declare here
        string name = "Eisen Sy";
        private void button2_Click(object sender, EventArgs e)
        {
            int x = 100;
            name = "Naruto";
            //MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            short b;
            float c;
            double d;
            //Converts numbers to numbers
            a = (int)(100 + 3.5);
            a = 100 + (int)3.5;
            c = (float)3.14159;
            c = 3.14159f;
            d = 3.14159f;
            //Converts numbers to string
            string x;
            x = d.ToString();
            //Converts strings to numbers
            d = double.Parse(x);
        }

        //Declare here
    }
}
