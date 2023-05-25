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
    public partial class ViewCustomers : UserControl
    {
        public ViewCustomers()
        {
            InitializeComponent();
            FillTable();
        }

        void FillTable()
        {
            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = $"SELECT SSN, Name, Address, Type, Bnumber as [Branch Number] FROM [User] Where Type = 'Customer' AND Bnumber = {SessionManager.branchNumber}";
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UsersDataGrid.DataSource = dt;
            databaseObject.CloseConnection();

        }
        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
