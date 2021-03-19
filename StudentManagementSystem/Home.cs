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
        //private int _ticks;
        //int seconds;

        //int minutes;
        //int hours;
        User _user;
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=CollegeManagement;Trusted_Connection=True;";
        
    
        public Home(User user)
        {
            InitializeComponent();

            _user = user;
            timer1.Start();
            //seconds = minutes = hours = 0;

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
            

            txtPassword.Hide();
            btnResetPassword.Hide();
            lblUsername.Text = "Welcome     " + _user.Name;
            lblMalayalm.Text = "Malayalam     :"+_user.Malayalam.ToString();
            lblEnglish.Text =  "English            :"+_user.English.ToString();
            lblMaths.Text =    "Maths              :"+ _user.Maths.ToString();
            lblTotal.Text = "Total               :" + (_user.Malayalam + _user.English + _user.Maths);
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
            //seconds++;
           
            //lblSeconds.Text = seconds.ToString();
            //lblMinutes.Text = minutes.ToString();
            //lblHour.Text = hours.ToString();

        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.Show();
            btnResetPassword.Show();
            

           
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

        private void linkMark(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkTheme(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {


            //seconds = 0;
            //minutes=0;
            //hours = 0;

           
          

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            LoginPage obj = new LoginPage();
            obj.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
