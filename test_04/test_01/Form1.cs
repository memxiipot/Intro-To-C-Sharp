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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//FORM LOAD
        {
            String strcon = "SERVER = MARIE-VAIO; DATABASE = test_01; UID = sa; PWD = benilde";

            String strcom = "SELECT * FROM StudentData";

            SqlConnection con = new SqlConnection(strcon);

            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dtb = new DataTable("Students");

            da.Fill(dtb);

            dGV.DataSource = dtb;

            con.Close();
        }

        private void b2_Click(object sender, EventArgs e)//ADD
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void b3_Click(object sender, EventArgs e)//EDIT
        {
            Form3 f3 = new Form3();

            GlobalData.StudentID = int.Parse(dGV.SelectedCells[0].Value.ToString());
            GlobalData.FirstName = dGV.SelectedRows[0].Cells[1].Value.ToString();
            GlobalData.LastName = dGV.SelectedRows[0].Cells[2].Value.ToString();
            GlobalData.YearLevel = int.Parse(dGV.SelectedRows[0].Cells[3].Value.ToString());

            f3.ShowDialog();
        }

        private void b4_Click(object sender, EventArgs e)//DELETE
        {

        }

        private void b1_Click(object sender, EventArgs e)//SEARCH
        {

        }

        
    }
}
