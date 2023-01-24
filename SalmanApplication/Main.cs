using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmanApplication
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            displayRecords();

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            Insert insRecord = new Insert();
            insRecord.ShowDialog();
            displayRecords();       // When we click close button after inserting data in INSERT RECORD, the data gridView is updated
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void displayRecords()
        {
            DataTable recordTable = new DataTable();

            recordTable.Clear();

            string connect = "server=127.0.0.1; port=3306; username=root; password=; database=salmanApplication";
            MySqlConnection DBconnect = new MySqlConnection(connect);

            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Records", DBconnect);
            MySqlDataReader readDB= cmd.ExecuteReader();

            recordTable.Load(readDB);
            dataGrid.DataSource= recordTable;
            
            readDB.Close();
            DBconnect.Close();

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Update updRecord = new Update();
            updRecord.ShowDialog();
            displayRecords();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Delete delRecord = new Delete();
            delRecord.ShowDialog();
            displayRecords();
        }
    }
}
