using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
                float mTraveled = float.Parse(t1.Text);
                float priceMile = float.Parse(t2.Text);           
                float amtDue = mTraveled * priceMile;
                long ptsEarned = (long)mTraveled / 10;
            
                String travType = "";

                //points earned are determined by the miles traveled
                //1 pt = 10 miles

                if (ptsEarned <= 50)
                {
                    travType = "Bronze";
                }
                else if (ptsEarned >= 51 && ptsEarned <= 100)
                {
                    travType = "Silver";
                }
                else if (ptsEarned >= 101 && ptsEarned <= 200)
                {
                    travType = "Gold";
                }
                else
                {
                    travType = "Platinum";
                }

                t3.Text = amtDue.ToString();

                t4.Text = ptsEarned.ToString();

                t5.Text = travType.ToString();

            
        }

        


    }
}
