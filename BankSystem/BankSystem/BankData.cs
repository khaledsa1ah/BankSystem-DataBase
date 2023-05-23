using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class BankData : UserControl
    {
        public BankData()
        {
            InitializeComponent();
        }

        private void BankDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //----------------------Bank------------------------------------

            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = "SELECT * FROM Bank";
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BankDataGrid.DataSource = dt;


            //-------------------Branch------------------------------ 


            // Create a new SQLite command
            string query2 = "SELECT * FROM Branch";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, databaseObject.myConnection);


            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter();
            adapter2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            BranchDataGrid.DataSource = dt2;


            databaseObject.CloseConnection();

        }
    }
}
