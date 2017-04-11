using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vector 1
            float x1 = float.Parse(v1x.Text);
            float y1 = float.Parse(v1y.Text);
            float z1 = float.Parse(v1z.Text);

            //vector 2
            float x2 = float.Parse(v2x.Text);
            float y2 = float.Parse(v2y.Text);
            float z2 = float.Parse(v2z.Text);

            float a, b, c;
            a = x1 / (float)Math.Sqrt((x1 * x1) + (y1 * y1) + (z1 * z1));
            b = y1 / (float)Math.Sqrt((x1 * x1) + (y1 * y1) + (z1 * z1));
            c = z1 / (float)Math.Sqrt((x1 * x1) + (y1 * y1) + (z1 * z1));

            nv1x.Text = a.ToString();
            nv1y.Text = b.ToString();
            nv1z.Text = c.ToString();

            float f, g, h;
            f = x2 / (float)Math.Sqrt((x2 * x2) + (y2 * y2) + (z2 * z2));
            g = y2 / (float)Math.Sqrt((x2 * x2) + (y2 * y2) + (z2 * z2));
            h = z2 / (float)Math.Sqrt((x2 * x2) + (y2 * y2) + (z2 * z2));

            nv2x.Text = f.ToString();
            nv2y.Text = g.ToString();
            nv2z.Text = h.ToString();

            float dot;
            dot = ((a * f) + (b * g) + (c * h));

            if (dot == 0) perPar.Text = "Perpendicular";
            else if (dot == 1) perPar.Text = "Parallel";
            else perPar.Text = "Not Perpendicular nor Parallel";


        }
    }
}
