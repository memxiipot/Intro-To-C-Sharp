using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Point_Rectangle_Intersection_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx.Text == "")
            {
                MessageBox.Show("Input Value for X-Coordinate");
                return;
            }
            if (ty.Text == "")
            {
                MessageBox.Show("Input Value for Y-Coordinate");
                return;
            }
            float x, y;
            bool bx, by;
            bx = float.TryParse(tx.Text, out x);
            by = float.TryParse(ty.Text, out y);
            if (!bx)
            {
                MessageBox.Show("Invalid X-Coordinate Input");
                return;
            }
            if (!by)
            {
                MessageBox.Show("Invalid Y-Coordinate Input");
                return;
            }
            
            //Check if point is on the right edge
            if (x == 2.0f && y >= -2.0f && y <= 2.0f)
            {
                lOut.Text = "RIGHT EDGE";
            }
            else if (x == -2.0f && y >= -2.0f && y <= 2.0f)
            {
                lOut.Text = "LEFT EDGE";
            }
            else if (y == 2.0f && x >= -2.0f && x <= 2.0f)
            {
                lOut.Text = "TOP EDGE";
            }
            else if (y == -2.0f && x >= -2.0f && x <= 2.0f)
            {
                lOut.Text = "BOTTOM EDGE";
            }
            else if (x > -2.0f && x < 2.0f && y > -2.0f && y < 2.0f)
            {
                lOut.Text = "INSIDE";
            }
            else
            {
                lOut.Text = "OUTSIDE";
            }
        }
    }
}
