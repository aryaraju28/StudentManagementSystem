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
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=CollegeManagement;Trusted_Connection=True;";
        int seconds, minutes, hours;
    
        public Home(User user)
        {
            InitializeComponent();

            _user = user;

            timer1.Start();
            seconds = minutes = hours = 0;
        }






        private void Home_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdatewindowPosition(this.Left, this.Top, _user.Id);
        }

        private void UpdatewindowPosition(int left, int top, int userid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("UpdateWindowPosition", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id",userid);
            command.Parameters.AddWithValue("Left_Offset", Left);
            command.Parameters.AddWithValue("Top_Offset", Top);
            command.ExecuteNonQuery();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(_user.Color));
            this.Left = _user.Left;
            this.Top = _user.Top;
            lblUsername.Text = "Welcome"   +  _user.Name;
            lblMalayalm.Text = _user.Malayalam.ToString();
            lblEnglish.Text = _user.English.ToString();
            lblMaths.Text = _user.Maths.ToString();
            int Total;
            Total = int.Parse(lblMalayalm.Text) + int.Parse(lblEnglish.Text) + int.Parse(lblMaths.Text);
            lblTotal.Text = Total.ToString();

            txtPassword.Hide();
            btnResetPassword.Hide();

        }

        private void lblTheme_Click(object sender, EventArgs e)
        {
            setColor(_user.Id);
           
        }

        private void setColor(int userid)
        {
            colorDialog1.ShowDialog();
            this.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb());
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SetColor", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", userid);
            command.Parameters.AddWithValue("Color", colorDialog1.Color.ToArgb().ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds>59)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes>59)
            {
                hours++;
                minutes = 0;
            }
            lblHour.Text = hours.ToString();
            lblMinutes.Text = minutes.ToString();
            lblSeconds.Text = seconds.ToString();
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            
            lblHour.Text = "00";
            lblMinutes.Text = "00";
            lblSeconds.Text = "00";
            hours = 0;
            minutes = 0;
            seconds = 0;

        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.Show();
            btnResetPassword.Show();
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();

            //SqlCommand command = new SqlCommand("UpdateLoginPassword", con);
            //command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("Password", txtPassword.Text);
            //command.ExecuteNonQuery();
            //con.Close();

           
        }

        private void setPassword(int userid)
        {
           SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("UpdateLoginPassword", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", userid);
            command.Parameters.AddWithValue("Password",txtPassword.Text);
            command.ExecuteNonQuery();
            con.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            setPassword(_user.Id);
            MessageBox.Show("Password Changed Successfully");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            LoginPage obj = new LoginPage();
            obj.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblMalayalm.Text = _user.Malayalam.ToString();
            lblEnglish.Text = _user.English.ToString();
            lblMaths.Text = _user.Maths.ToString();
            int Total;
            Total = int.Parse(lblMalayalm.Text) + int.Parse(lblEnglish.Text) + int.Parse(lblMaths.Text);
            lblTotal.Text = Total.ToString();
        }
    }
    
}
