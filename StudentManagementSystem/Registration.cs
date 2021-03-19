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
    public partial class Registration : Form

    {
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=CollegeManagement;Trusted_Connection=True;";

        public Registration()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
           

            

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            
            SqlCommand command = new SqlCommand("StudentRegister", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", txtName.Text);
            command.Parameters.AddWithValue("Username", txtUsername.Text);
            command.Parameters.AddWithValue("Password",txtPassword.Text);
            command.Parameters.AddWithValue("Malayalam", txtMalayalam.Text);
            command.Parameters.AddWithValue("English", txtEnglish.Text);
            command.Parameters.AddWithValue("Maths", txtMaths.Text);
            command.ExecuteNonQuery();
            
            
            MessageBox.Show("Account Successfully created" + "\n" + "Temporary Password   :" + txtPassword.Text);
            txtName.Text = txtUsername.Text = txtEnglish.Text = txtMalayalam.Text = txtMaths.Text = "";



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            StudentMark obj = new StudentMark();
            obj.Show();
            this.Hide();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void linkRandomPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            


        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtPassword.Visible=false;
            int minlength = 4;
            int maxlength = 4;
            string charAvailable = "0123456789";
            StringBuilder password = new StringBuilder();
            Random rde = new Random();
            int passwordLength = rde.Next(minlength, maxlength + 1);//random length for passwordis 8 -12 characters
            while (passwordLength-- > 0)
            password.Append(charAvailable[rde.Next(charAvailable.Length)]);
            txtPassword.Text = password.ToString();
        }
    }
}
