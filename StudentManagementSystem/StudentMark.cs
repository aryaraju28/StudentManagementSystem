using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class StudentMark : Form
    {
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;";



        public StudentMark()
        {
            InitializeComponent();
        }

        private void btnMarkSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("StudentMark", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Malayalam", txtMalayalam.Text);
            command.Parameters.AddWithValue("English", txtEnglish.Text);
            command.Parameters.AddWithValue("Maths", txtMaths.Text);



            command.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home obj = new Home();
            //obj.Show();
            //this.Hide();
        }
    }
}
