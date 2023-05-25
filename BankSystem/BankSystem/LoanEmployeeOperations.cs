using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class LoanEmployeeOperations : UserControl
    {
        public LoanEmployeeOperations()
        {
            InitializeComponent();
            FillGridView();
        }

        public void FillGridView()
        {
            Database database = new Database();
            database.OpenConnection();
            string query = $"SELECT * FROM Loan JOIN LoanType ON Loan.Type = LoanType.Type WHERE Bnumber = {SessionManager.branchNumber}";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoanDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LoanDataGridView.SelectedRows[0];

                string loanId = selectedRow.Cells["Lnumber"].Value.ToString();
                string state = selectedRow.Cells["Status"].Value.ToString();
                if (state == "Paid")
                {
                    MessageBox.Show("This loan is already paid, you can't accept it");
                    return;
                }
                string query = "UPDATE Loan SET Status = 'Accepted' WHERE Lnumber = @LoanId";

                Database database = new Database();
                database.OpenConnection();
                SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);
                myCommand.ExecuteNonQuery();

                query = $"UPDATE Loan SET EmpSSN = {SessionManager.SSN} WHERE Lnumber = @LoanId";

                myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);
                myCommand.ExecuteNonQuery();

                database.CloseConnection();
                MessageBox.Show("You accepted this loan, refresh to see the changes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoanDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LoanDataGridView.SelectedRows[0];

                string loanId = selectedRow.Cells["Lnumber"].Value.ToString();
                string state = selectedRow.Cells["Status"].Value.ToString();
                if(state == "Paid")
                {
                    MessageBox.Show("This loan is already paid, you can't reject it");
                    return;
                }

                string query = "UPDATE Loan SET Status = 'Rejected' WHERE Lnumber = @LoanId";

                Database database = new Database();
                database.OpenConnection();
                SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);

                myCommand.ExecuteNonQuery();
                query = $"UPDATE Loan SET EmpSSN = {SessionManager.SSN} WHERE Lnumber = @LoanId";

                myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);
                myCommand.ExecuteNonQuery();
                database.CloseConnection();
                MessageBox.Show("You rejected this loan, refresh to see the changes");

            }
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

        private void LoanEmployeeOperations_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LoanDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LoanDataGridView.SelectedRows[0];

                string loanId = selectedRow.Cells["Lnumber"].Value.ToString();
                string query = "UPDATE Loan SET Status = 'Paid' WHERE Lnumber = @LoanId";

                Database database = new Database();
                database.OpenConnection();
                SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);
                myCommand.ExecuteNonQuery();
                query = $"UPDATE Loan SET EmpSSN = {SessionManager.SSN} WHERE Lnumber = @LoanId";

                myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@LoanId", loanId);
                myCommand.ExecuteNonQuery();
                database.CloseConnection();
                MessageBox.Show("You paid this loan, refresh to see the changes");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillGridView();
        }
    }
}
