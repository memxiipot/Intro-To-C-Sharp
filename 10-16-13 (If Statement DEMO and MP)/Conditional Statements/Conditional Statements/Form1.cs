using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conditional_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (td1.Text == "")
            {
                MessageBox.Show("Input Dividend");
            }
            else
            {
                if (td2.Text == "")
                {
                    MessageBox.Show("Input Divisor");
                }
                else
                {
                    float d1, d2, q;
                    d1 = float.Parse(td1.Text);
                    d2 = float.Parse(td2.Text);
                    if (d2 == 0)
                    {
                        MessageBox.Show("Cannot divide by 0!");
                    }
                    else
                    {
                        q = d1 / d2;
                        tq.Text = q.ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   //TryParse
            float d1, d2;
            bool b1, b2;
            b1 = float.TryParse(td1.Text, out d1);
            if (b1 == true)
            {   //input is a valid number-proceed with computation
                b2 = float.TryParse(td2.Text, out d2);
                if (b2 == true)
                {   //divisor is valid
                    float q;
                    q = d1 / d2;
                    tq.Text = q.ToString();
                }
                else
                {   //divisor is invalid
                    MessageBox.Show("Invalid Divisor");
                }
            }
            else
            {   //input is invalid
                MessageBox.Show("Invalid Dividend");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure?",
                            "Quit Application",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {   //user chose to exit
                Application.Exit();
            }
            else
            {   //User chose to stay
                MessageBox.Show("I knew it!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tun.Text == "")
            {
                MessageBox.Show("Input Username");
            }
            else
            {
                if (tpw.Text.Length < 7)
                {
                    MessageBox.Show(
                        "Password must be at least 7 chars");
                }
                else
                {
                    MessageBox.Show("User registered");
                }
            }
        }
    }
}
