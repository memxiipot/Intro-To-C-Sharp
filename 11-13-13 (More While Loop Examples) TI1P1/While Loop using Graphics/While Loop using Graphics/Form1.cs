using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace While_Loop_using_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Blue);

            int i = 1;
            while (i <= 200)
            {
                g.DrawEllipse(p, i, 0, 100, 100);
                i += 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);
            int i = 1;
            while (i <= 200)
            {
                g.DrawEllipse(p, i, i, 100 + i, 100 + i);
                i += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);
            Pen rp = new Pen(Color.Red, 2.0f);

            int i = 0;
            while (i <= 150)
            {
                g.DrawRectangle(p, i, i, 100 + i, 100);
                g.DrawEllipse(rp, i, i, 100 + i, 100);
                i += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);

            int i = 0;
            while (i <= 100)
            {
                g.DrawLine(p, 0, i, i, i);
                i++;
            }

            //int x = 0;
            //int y = 0;
            //int a = 0;
            //int b = 0;
            //while (y <= 100)
            //{
            //    g.DrawLine(p, x, y, a, b);
            //    y++;
            //    a++;
            //    b++;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);
            //Draw a line from point(0,0) to (x, 100)
            int x = 0;
            while (x <= 100)
            {
                g.DrawLine(p, 0, 0, x, 100);
                x++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);
            int b = 0;
            while (b <= 100)
            {
                g.DrawLine(p, 0, b, 50, 50);
                b++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2.0f);
            int x = 100;
            int y = 0;
            int a = 200;
            int b = 0;
            while (y <= 100)
            {
                g.DrawLine(p, x, y, a, b);
                x--;
                y++;
                a--;
                b++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("<SELECT YEAR>");
            int y = 1900;
            while (y <= 2100)
            {
                comboBox1.Items.Add(y);
                y++;
            }
            comboBox1.Items.Clear();
            y = 2013;
            while (y >= 1900)
            {
                comboBox1.Items.Add(y);
                y--;
            }

        }
    }
}
