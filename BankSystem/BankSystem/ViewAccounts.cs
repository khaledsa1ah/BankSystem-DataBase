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
    public partial class ViewAccounts : UserControl
    {
        public ViewAccounts()
        {
            InitializeComponent();
            FillTable();
        }

        void FillTable()
        {
            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = $"SELECT AccNumber as [Account Number], SSN, Balance, Type FROM [Account] WHERE SSN = '{SessionManager.SSN}'";
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UserAccountsDataGrid.DataSource = dt;
            databaseObject.CloseConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserAccountsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = UserAccountsDataGrid.SelectedRows[0];

                string AccNumber = selectedRow.Cells["Account Number"].Value.ToString();
                string query = "DELETE FROM Account Where AccNumber = @accNumber";
                Database database = new Database();
                database.OpenConnection();
                SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@accNumber", AccNumber);
                myCommand.ExecuteNonQuery();
                database.CloseConnection();
                MessageBox.Show("Acccount has been deleted!. Refresh to see updates");
            }
        }

        private void ViewAccounts_Load(object sender, EventArgs e)
        {

        }
    }
}
