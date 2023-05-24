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
    public partial class LoanTypesView : UserControl
    {
        public LoanTypesView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = $"SELECT Type FROM LoanType WHERE Bnumber = {SessionManager.branchNumber}";
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();


            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable loanTypeTable = new DataTable();
            adapter.Fill(loanTypeTable);
            LoanTypesDataGrid.DataSource = loanTypeTable;

            databaseObject.CloseConnection();
        }

        private void LoanTypesView_Load(object sender, EventArgs e)
        {

        }
    }
}
