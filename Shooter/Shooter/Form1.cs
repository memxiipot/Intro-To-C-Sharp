using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ship player1 = new Ship();
        Graphics gfx;
        Pen pen;
        Pen pen2;
        Pen pen3;
        Pen pen4;
        Pen pen5;

        Bullet b = new Bullet();
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            pen = new Pen(Color.Black, 5.0f);
            pen2 = new Pen(Color.Gray, 5.0f);
            pen3 = new Pen(Color.Red, 5.0f);
            pen4 = new Pen(Color.Orange, 5.0f);
            pen5 = new Pen(Color.DimGray, 5.0f);
        }

        private void tRender_Tick(object sender, EventArgs e)
        {
            gfx.Clear(this.BackColor);
            player1.DrawShip(gfx, pen, pen2, pen3, pen4, pen5);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = true;
            }

            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = true;
            }
            if (e.KeyCode.ToString() == "Space")
            {
                b.X = player1.X;
                b.Y = player1.Y;
                tBullet.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = false;
            }

            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = false;
            }
        }

        private void tBullet_Tick(object sender, EventArgs e)
        {
            b.DrawBullet(gfx, pen);
            if (b.Active == false)
            {
                tBullet.Enabled = false;
                b.ResetBullet();
            }
        }

    }
}
