using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int numSum;
            num1 = int.Parse(AddOp1.Text);
            num2 = int.Parse(AddOp2.Text);
            numSum = num1 + num2 ;
            Sum.Text = numSum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int numDif;
            num1 = int.Parse(SubOp1.Text);
            num2 = int.Parse(SubOp2.Text);
            numDif = num1 - num2;
            Difference.Text = numDif.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int numProd;
            num1 = int.Parse(MultOp1.Text);
            num2 = int.Parse(MultOp2.Text);
            numProd = num1 * num2;
            Product.Text = numProd.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1;
            float num2;
            float numQuo;
            num1 = float.Parse(QuoOp1.Text);
            num2 = float.Parse(QuoOp2.Text);
            numQuo = num1 / num2;
            Quotient.Text = numQuo.ToString();
        }
    }
}
