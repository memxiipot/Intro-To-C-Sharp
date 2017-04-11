using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float mass, vel, ht, ke, pe, me;
            mass = float.Parse(t1.Text);
            vel = float.Parse(t2.Text);
            ht = float.Parse(t3.Text);

            ke = 1.0f / 2 * mass * vel * vel;
            t4.Text = ke.ToString();

            pe = mass * 9.8f * ht;
            t5.Text = pe.ToString();

            me = ke + pe;
            t6.Text = me.ToString();
        }
    }
}
