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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strcon = "SERVER = MARIE-VAIO; DATABASE = test_01; UID = sa; PWD = benilde";

            string strcom = "UPDATE StudentData SET "
                    + "FirstName = '" + t2.Text + "', "
                    + "LastName = '" + t3.Text + "', "
                    + "YearLevel = '" + t4.Text + "' WHERE StudentID = " + GlobalData.StudentID;

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
    }
}
