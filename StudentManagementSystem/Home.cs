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
    public partial class Home : Form
    {
        User _user;
        //String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;";

        public Home(User user)
        {
            InitializeComponent();

            _user = user;

        }






        private void Home_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        //private void updatewindowPosition(int left, int top, int id)
        //{


        //    //SqlConnection con = new SqlConnection(connectionString);
        //    //con.Open();
        //    //SqlCommand command = new SqlCommand("UpdateWindowPosition", con);
        //    //command.CommandType = CommandType.StoredProcedure;
        //    //command.Parameters.AddWithValue("Id", Id);
        //    //command.Parameters.AddWithValue("Left", Left);
        //    //command.Parameters.AddWithValue("Top", Top);



        //    //command.ExecuteNonQuery();
        //    //con.Close();




        //}

    }
}
