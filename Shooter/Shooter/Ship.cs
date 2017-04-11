using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shooter
{
    class Ship
    {
        public int X = 300;
        public int Y = 400;

        public int Speed = 15;
        public bool IsMovingRight = false;
        public bool IsMovingLeft = false;

    public void DrawShip(Graphics g, Pen p, Pen q, Pen r, Pen o, Pen w)
    {
            //g.DrawLine(p, X, Y-25, X-25, Y+10);
            //g.DrawLine(p, X-25, Y+10, X+25, Y+10);
            //g.DrawLine(p, X + 25, Y + 10, X, Y - 25);
        g.DrawLine(p, X - 30, Y, X - 30, Y + 15);
        g.DrawLine(r, X - 30, Y + 15, X - 30, Y + 25);

        g.DrawLine(p, X - 25, Y - 5, X - 25, Y);
        g.DrawLine(w, X - 25, Y, X - 25, Y + 10);
        g.DrawLine(p, X - 25, Y + 10, X - 25, Y + 15);
        g.DrawLine(o, X - 25, Y + 15, X - 25, Y + 25);
        g.DrawLine(r, X - 25, Y + 25, X - 25, Y + 30);

        g.DrawLine(p, X - 20, Y, X - 20, Y + 5);
        g.DrawLine(w, X - 20, Y + 5, X - 20, Y + 10);
        g.DrawLine(p, X - 20, Y + 10, X - 20, Y + 15);
        g.DrawLine(r, X - 20, Y + 15, X - 20, Y + 25);

        g.DrawLine(p, X - 15, Y - 20, X - 15, Y);
        g.DrawLine(q, X - 15, Y, X - 15, Y + 15);
        g.DrawLine(p, X - 15, Y + 15, X - 15, Y + 20);

        g.DrawLine(p, X - 10, Y - 30, X - 10, Y - 15);
        g.DrawLine(q, X - 10, Y - 15, X - 10, Y + 20);
        g.DrawLine(p, X - 10, Y + 20, X - 10, Y + 25);

        g.DrawLine(p, X - 5, Y - 35, X - 5, Y - 25);
        g.DrawLine(q, X - 5, Y - 25, X - 5, Y - 10);
        g.DrawLine(p, X - 5, Y - 10, X - 5, Y - 5);
        g.DrawLine(q, X - 5, Y - 5, X - 5, Y + 10);
        g.DrawLine(w, X - 5, Y + 10, X - 5, Y + 20);
        g.DrawLine(p, X - 5, Y + 20, X - 5, Y + 25);

        g.DrawLine(p, X, Y - 35, X, Y - 30);
        g.DrawLine(q, X, Y - 30, X, Y - 15);
        g.DrawLine(p, X, Y - 15, X, Y - 10);
        g.DrawLine(r, X, Y - 10, X, Y - 5);
        g.DrawLine(p, X, Y - 5, X, Y);
        g.DrawLine(q, X, Y, X, Y + 5);
        g.DrawLine(p, X, Y + 5, X, Y + 15);
        g.DrawLine(q, X, Y + 15, X, Y + 20);
        g.DrawLine(p, X, Y + 20, X, Y + 25);

        g.DrawLine(p, X + 5, Y - 35, X + 5, Y - 25);
        g.DrawLine(q, X + 5, Y - 25, X + 5, Y - 10);
        g.DrawLine(p, X + 5, Y - 10, X + 5, Y - 5);
        g.DrawLine(q, X + 5, Y - 5, X + 5, Y + 10);
        g.DrawLine(w, X + 5, Y + 10, X + 5, Y + 20);
        g.DrawLine(p, X + 5, Y + 20, X + 5, Y + 25);

        g.DrawLine(p, X + 10, Y - 30, X + 10, Y - 15);
        g.DrawLine(q, X + 10, Y - 15, X + 10, Y + 20);
        g.DrawLine(p, X + 10, Y + 20, X + 10, Y + 25);

        g.DrawLine(p, X + 15, Y - 20, X + 15, Y);
        g.DrawLine(q, X + 15, Y, X + 15, Y + 15);
        g.DrawLine(p, X + 15, Y + 15, X + 15, Y + 20);

        g.DrawLine(p, X + 20, Y, X + 20, Y + 5);
        g.DrawLine(w, X + 20, Y + 5, X + 20, Y + 10);
        g.DrawLine(p, X + 20, Y + 10, X + 20, Y + 15);
        g.DrawLine(r, X + 20, Y + 15, X + 20, Y + 25);

        g.DrawLine(p, X + 25, Y - 5, X + 25, Y);
        g.DrawLine(w, X + 25, Y, X + 25, Y + 10);
        g.DrawLine(p, X + 25, Y + 10, X + 25, Y + 15);
        g.DrawLine(o, X + 25, Y + 15, X + 25, Y + 25);
        g.DrawLine(r, X + 25, Y + 25, X + 25, Y + 30);

        g.DrawLine(p, X + 30, Y, X + 30, Y + 15);
        g.DrawLine(r, X + 30, Y + 15, X + 30, Y + 25);

            if (IsMovingLeft == true)
            {
                X = X - Speed;
            }

            if (IsMovingRight == true)
            {
                X = X + Speed;
            }

        }
    }
}
