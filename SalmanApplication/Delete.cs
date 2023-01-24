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

namespace SalmanApplication
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            displayRecord();
        }

        public void displayRecord()
        {
            DataTable recordTable = new DataTable();

            recordTable.Clear();

            string connect = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection DBconnect = new MySqlConnection(connect);

            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Records", DBconnect);
            MySqlDataReader readDB = cmd.ExecuteReader();

            recordTable.Load(readDB);
            DGVtable.DataSource = recordTable;

            readDB.Close();
            DBconnect.Close();
        }

        private void delBTN_Click(object sender, EventArgs e)
        {
            int record_ID = Convert.ToInt32(DGVtable.Rows[DGVtable.CurrentRow.Index].Cells[0].Value);

            string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection conDB = new MySqlConnection(connectionString);

            

            if(MessageBox.Show("Are you sure you want to delete the Record?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conDB.Open();

                MySqlCommand cmd = new MySqlCommand("Delete from Records where Record_ID = '" + record_ID + "'", conDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");

                conDB.Close();
            }
            else
            {
                MessageBox.Show("No record deleted","Delete Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
