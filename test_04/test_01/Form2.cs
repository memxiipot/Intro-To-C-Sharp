using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strcon = "SERVER = MARIE-VAIO; DATABASE = test_01; UID = sa; PWD = benilde";

            string strcom = "INSERT INTO StudentData VALUES ("
                    + t1.Text + ",'"
                    + t2.Text + "', '"
                    + t3.Text + "', '"
                    + t4.Text + "' ) ";

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);
            com.ExecuteNonQuery();

            con.Close();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            t1.Text = GlobalData.StudentID.ToString();
            t2.Text = GlobalData.FirstName;
            t3.Text = GlobalData.LastName;
            t4.Text = GlobalData.YearLevel.ToString();

        }
                
    }
}
