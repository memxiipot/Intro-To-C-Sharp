using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISPROG1LongExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double mass;
            double velocity;
            double height;
            double kine;
            double potential;
            double mechanical;
            mass = double.Parse(t1.Text);
            velocity = double.Parse(t2.Text);
            height = double.Parse(t3.Text);
            kine = (0.5 * mass * (velocity * velocity));
            potential = (mass * 9.8 * height);
            mechanical = kine + potential;
            t4.Text = kine.ToString();
            t5.Text = potential.ToString();
            t6.Text = mechanical.ToString();

            }

                
    }
}
