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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            string conSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection conDB = new MySqlConnection(conSTR);
            
            string fname = fnametxt.Text.ToString();
            string lname = lnametxt.Text.ToString();
            string mail = emailtxt.Text.ToString();
            string contct = conttxt.Text.ToString();
            string usname = unametxt.Text.ToString();
            string uspass = upasstxt.Text.ToString();
            string dateOB = doB.Value.ToString("dd-MM-yyyy");       // Getting only date from DateTimePicker
            string gndr;
            if(maleRB.Checked == true)
            {
                gndr = maleRB.Text.ToString();

            }
            else
            {
                gndr = femaleRB.Text.ToString();
            }

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(contct) ||
                string.IsNullOrEmpty(usname) || string.IsNullOrEmpty(uspass) || string.IsNullOrEmpty(dateOB) || string.IsNullOrEmpty(gndr))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
               conDB.Open();

               // Inserting Data in userSignUp Table
               MySqlCommand cmD= new MySqlCommand("Insert into userSignUp(UID, FirstName, LastName, Email, Contact, Uname, Upassword, DoB, Gender) values (NULL, '"+fname+"', '"+lname+"', '"+mail+"', '"+contct+"', '"+usname+"', '"+uspass+"', '"+dateOB+"', '"+gndr+"')", conDB);
               cmD.ExecuteNonQuery();

                // Inserting Username & Password from SignUp Form and Inserting in Login Table to allow user to Login with account created
                MySqlCommand cMd = new MySqlCommand("Insert into userLogin(User_name, User_password) values('"+usname+"','"+uspass+"')",conDB); 
                cMd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully :) ");
                conDB.Close();

                //Login back = new Login();
                MessageBox.Show("Please Login With Account Created !");
                //this.Hide();
                //back.Show();

            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
