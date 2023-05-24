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

            databaseObject.CloseConnection();

        }

        private void BankData_Load(object sender, EventArgs e)
        {

        }
    }
}
