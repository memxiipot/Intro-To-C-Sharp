using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace midterms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y, d;
            x = float.Parse(tx.Text);
            y = float.Parse(ty.Text);

            

            //Version 1
            d = x * x + y * y;
            double r = d;
            r = Math.Sqrt(r);
            td.Text = r.ToString();

            //Version 2
            d = (float)Math.Sqrt((double)(d));

            //Version 3
            d = (float)Math.Sqrt(d);

            //Version 4
            d = (float)Math.Sqrt(x * x + y * y);

            td.Text = d.ToString();

            if (d == 2.0f) to.Text = "PERIMETER";
            else if (d > 2.0f) to.Text = "OUTSIDE";
            else to.Text = "INSIDE";
        }
    }
}
