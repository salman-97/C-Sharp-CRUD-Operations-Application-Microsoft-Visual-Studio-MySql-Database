using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SalmanApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string connectSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection connectDB = new MySqlConnection(connectSTR);
            

            string uname = unametxt.Text.ToString();
            string upass = passtxt.Text.ToString(); 

            if(string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upass))
            {
                MessageBox.Show("Please enter Username or Password");
            }
            else
            {
                try
                {
                    connectDB.Open();
                    MySqlCommand cmd = new MySqlCommand("Select * from userLogin, userSignUp",connectDB);
                    MySqlDataReader read = cmd.ExecuteReader();
                    while(read.Read())
                    {
                        if(uname == read.GetString("User_name") && upass == read.GetString("User_password"))
                        {
                            MessageBox.Show(uname + " " + "Successfully Login");
                            MainScreen app= new MainScreen();
                            this.Hide();
                            app.Show();
                            return;
                        }
                    }
                    read.Close();
                    connectDB.Close();
                }
                catch (Exception ex)
                {
                    connectDB.Close();  
                }
                finally
                {
                    connectDB.Close();
                    
                }
                MessageBox.Show("Invalid Username or Password !");
            }
        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp reg= new SignUp();
            reg.ShowDialog();
        }
    }
}
