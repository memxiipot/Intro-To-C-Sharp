using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointRectangleIntersection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float xCoor, yCoor; 
            String output;
            xCoor = float.Parse(t1.Text);
            yCoor = float.Parse(t2.Text);
            output = "";      

            
            if (xCoor < 2.0F && xCoor > -2.0F && yCoor < 2.0F && yCoor > -2.0F)
            
                output = "INSIDE";
            
            //return;
            else if (xCoor == -2.0F && yCoor == -2.0F)
            {
                output = "BOTTOM LEFT EDGE";
            }
            else if (xCoor == -2.0F && yCoor == 2.0F)
            {
                output = "TOP LEFT EDGE";
            }
            else if (xCoor == 2.0F && yCoor == -2.0F)
            {
                output = "BOTTOM RIGHT EDGE";
            }
            else if (xCoor == 2.0F && yCoor == 2.0F)
            {
                output = "TOP RIGHT EDGE";
            }
  
            else if (xCoor <= 2.0F && xCoor >= -2.0F && yCoor == 2.0F)
            {
                output = "TOP EDGE";
            }
            else if (xCoor <= 2.0F && xCoor >= -2.0F && yCoor == -2.0F)
            {
                output = "BOTTOM EDGE";
            }
            else if (xCoor == -2.0F && yCoor <= 2.0F && yCoor >= -2.0F)
            {
                output = "LEFT EDGE";
            }
            else if (xCoor == 2.0F && yCoor <= 2.0F && yCoor >= -2.0F)
            {
                output = "RIGHT EDGE";
            }
            else {
                output = "OUTSIDE";
            }
            label.Text = output.ToString();
            
            

        }
    }
}
