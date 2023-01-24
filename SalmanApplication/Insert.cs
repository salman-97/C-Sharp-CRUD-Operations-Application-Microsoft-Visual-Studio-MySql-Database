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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void bkBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insBTN_Click(object sender, EventArgs e)
        {
            string connect = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection DBconnect = new MySqlConnection(connect);

            string fname = insFname.Text.ToString();
            string lname = insLname.Text.ToString();
            string emAd = insEmail.Text.ToString();
            string getGender;
            if(insmaleRB.Checked == true)
            {
                getGender= insmaleRB.Text.ToString();
            }
            else
            {
                getGender= insfemaleRB.Text.ToString();
            }
            string counTry = insCountry.Text.ToString();
            string conT = insCont.Text.ToString();


            if(string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(emAd) || 
                string.IsNullOrEmpty(getGender) || string.IsNullOrEmpty(counTry) || string.IsNullOrEmpty(conT))
            {
                MessageBox.Show("All field are Required");
            }
            else 
            {
                DBconnect.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT into Records (Record_ID, FirstName, LastName, EmailAdd, Gender, Country, Contact) " +
                "values (NULL, '"+fname+"', '"+lname+"', '"+emAd+"',  '"+getGender+"', '"+counTry+"', '"+conT+"')",DBconnect);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully :)");
                DBconnect.Close();

            }
        }
    }
}
