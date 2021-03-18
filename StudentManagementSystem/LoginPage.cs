using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginPage : Form
    {
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=CollegeManagement;Trusted_Connection=True;";

        public LoginPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("please enter username and password");
                textUsername.Focus();
            }
           
            User loggndUser = Login(textUsername.Text, txtPassword.Text);
            if(loggndUser!=null)
            {
                Home homepage = new Home(loggndUser);
                homepage.Show();
                this.Hide();
            }

           

        }

        private User Login(string username, string password)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("StudentLogin", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);


            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            User user = new User();
            user.Id = Convert.ToInt32(reader["Id"]);
            user.Name = reader["Name"].ToString();
            
            user.Username = reader["Username"].ToString();
            user.Password = reader["Password"].ToString();
            user.Malayalam = Convert.ToInt32(reader["Malayalam"]);
            user.English = Convert.ToInt32(reader["English"]);

            user.Maths = Convert.ToInt32(reader["Maths"]);
            user.Color = reader["Color"].ToString();
            user.Left = Convert.ToInt32(Convert.ToInt32(reader["Left_Offset"]));
            user.Top = Convert.ToInt32(Convert.ToInt32(reader["Top_Offset"]));

            return user;
            con.Close();

        }
    }
}
