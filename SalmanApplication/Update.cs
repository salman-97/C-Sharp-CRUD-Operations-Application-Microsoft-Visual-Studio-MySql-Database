using MySql.Data.MySqlClient;
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
using MySqlX.XDevAPI.Relational;

namespace SalmanApplication
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            displayRecords();
        }
        public void displayRecords()
        {
            DataTable recordTable = new DataTable();

            recordTable.Clear();

            string connect = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection DBconnect = new MySqlConnection(connect);

            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Records", DBconnect);
            MySqlDataReader readDB = cmd.ExecuteReader();

            recordTable.Load(readDB);
            DGVtable.DataSource= recordTable;

            readDB.Close();
            DBconnect.Close();
        }

        private void DGVtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            updFname.Text = DGVtable.SelectedRows[0].Cells[1].Value.ToString();
            updLname.Text = DGVtable.SelectedRows[0].Cells[2].Value.ToString();
            updEmail.Text = DGVtable.SelectedRows[0].Cells[3].Value.ToString();
            updCountry.Text = DGVtable.SelectedRows[0].Cells[5].Value.ToString();
            updCont.Text = DGVtable.SelectedRows[0].Cells[6].Value.ToString();
            string chk = DGVtable.SelectedRows[0].Cells[4].Value.ToString();

            if(chk == "Female")
            {
                updFemaleRB.Checked = true;
            }
            else
            {
                updMaleRB.Checked = true;
            }
        }

        private void updBTN_Click(object sender, EventArgs e)
        {
            int record_ID = Convert.ToInt32(DGVtable.Rows[DGVtable.CurrentRow.Index].Cells[0].Value);

            string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection conDB = new MySqlConnection(connectionString);

            string getGender;
            if(updMaleRB.Checked)
            {
                getGender = updMaleRB.Text.ToString();
            }
            else
            {
                getGender = updFemaleRB.Text.ToString();
            }

            if(string.IsNullOrEmpty(updFname.Text) || string.IsNullOrEmpty(updLname.Text) || string.IsNullOrEmpty(updEmail.Text) ||
                string.IsNullOrEmpty(getGender) || string.IsNullOrEmpty(updCountry.Text) || string.IsNullOrEmpty(updCont.Text))
            {
                MessageBox.Show("No Empty Fields are Allowed !");
            }
            else
            {
                conDB.Open();
                MySqlCommand cmd = new MySqlCommand("Update Records SET FirstName=@fname, LastName=@lname, EmailAdd=@mail, Gender=@gen, Country=@country, Contact=@cnt where Record_ID = '"+record_ID+"'",conDB);
                cmd.Parameters.AddWithValue("@fname", updFname.Text.ToString());
                cmd.Parameters.AddWithValue("@lname", updLname.Text.ToString());
                cmd.Parameters.AddWithValue("@mail", updEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@gen", getGender);
                cmd.Parameters.AddWithValue("@country", updCountry.Text.ToString());
                cmd.Parameters.AddWithValue("@cnt", updCont.Text.ToString());
                cmd.Parameters.AddWithValue("@Record_ID", record_ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully :)");
                conDB.Close();
            }
        }
    }
}
