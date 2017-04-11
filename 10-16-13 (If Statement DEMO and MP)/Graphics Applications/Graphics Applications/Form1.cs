using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x;
            Form1 f;            //Declaration
            f = new Form1();    //Instantiation (allocate memory)
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b;
            b = new Button();
            b.Size = new Size(100, 100);
            b.Location = new Point(200, 10);
            b.Text = "Magic Button";
            Controls.Add(b);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen p;
            p = new Pen(Color.Black, 2.5f);
            g.DrawLine(p, 0, 0, 100, 100);
            
            Pen rp;
            rp = new Pen(Color.Red, 5.0f);
            g.DrawLine(rp, 100, 0, 0, 100);
            g.DrawRectangle(p, 100, 100, 100, 100);
            g.DrawEllipse(rp, 0, 0, 100, 100);
            Brush b;
            b = new SolidBrush(Color.Blue);
            g.FillRectangle(b, 0, 100, 100, 100);
            Brush gb;
            gb = new SolidBrush(Color.Green);
            g.FillEllipse(gb, 100, 0, 100, 100);
        }
    }
}
