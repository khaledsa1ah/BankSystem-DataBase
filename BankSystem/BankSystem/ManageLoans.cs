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
    public partial class ManageLoans : Form
    {
        public ManageLoans()
        {
            InitializeComponent();
            FillGridView();
        }

        public void FillGridView()
        {
            Database database = new Database();
            database.OpenConnection();
            string query = "SELECT * FROM Loan";
            using (SQLiteCommand command = new SQLiteCommand(query, database.myConnection))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Bind the DataTable to the DataGridView
                LoanDataGridView.DataSource = table;
            }

            // Close the connection
            database.CloseConnection();
        }

        private void LoanDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < LoanDataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = LoanDataGridView.Rows[e.RowIndex];
                // Retrieve loan data from the selected row
                string loanId = selectedRow.Cells["Lnumber"].Value.ToString();
                string loanAmount = selectedRow.Cells["Amount"].Value.ToString();
                string loanType = selectedRow.Cells["Type"].Value.ToString();

                // Process the loan data as needed
                MessageBox.Show($"Loan ID: {loanId}\nLoan Amount: {loanAmount}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoanDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LoanDataGridView.SelectedRows[0];
                LoanDataGridView.Rows.Remove(selectedRow);
            }
            string loanId = LoanDataGridView.SelectedRows[0].Cells["Lnumber"].Value.ToString();
            string query = $"@UPDATE Loan SET Status = \'Accepted\' WHERE Lnumber = {loanId}";

            Database database = new Database();
            database.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            myCommand.ExecuteNonQuery();
            database.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoanDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LoanDataGridView.SelectedRows[0];
                LoanDataGridView.Rows.Remove(selectedRow);
            }
            string loanId = LoanDataGridView.SelectedRows[0].Cells["Lnumber"].Value.ToString();
            string query = $"@UPDATE Loan SET Status = \'Rejected\' WHERE Lnumber = {loanId}";

            Database database = new Database();
            database.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            myCommand.ExecuteNonQuery();
            database.CloseConnection();

        }

        private void LoanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageLoans_Load(object sender, EventArgs e)
        {

        }
    }
}
