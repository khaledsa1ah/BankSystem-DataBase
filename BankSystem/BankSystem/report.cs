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
    public partial class report : UserControl
    {
        public report()
        {
            InitializeComponent();
        }
        private void GenerateReport()
        {
            // Clear the DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Metric", "Metric");
            dataGridView.Columns.Add("Value", "Value");

            Database connection = new Database();

            string query = "";
            SQLiteCommand command;

            connection.OpenConnection();


            // Retrieve the number of Banks
            query = "SELECT COUNT(*) as cnt FROM Bank";
            command = new SQLiteCommand(query, connection.myConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string bankCount = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    bankCount = reader["cnt"].ToString();
                }

            }

            dataGridView.Rows.Add("Number of Banks", bankCount);

            // Retrieve the number of Branches
            query = "SELECT COUNT(*) as cnt FROM Branch";
            command = new SQLiteCommand(query, connection.myConnection);
            reader = command.ExecuteReader();
            string branchCount = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    branchCount = reader["cnt"].ToString();
                }

            }

            dataGridView.Rows.Add("Number of Branches", branchCount);


            // Retrieve the number of Customers
            query = "SELECT COUNT(*) as cnt FROM User WHERE Type = 'Customer'";
            command = new SQLiteCommand(query, connection.myConnection);
            reader = command.ExecuteReader();
            string customerCount = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customerCount = reader["cnt"].ToString();
                }

            }

            dataGridView.Rows.Add("Number of Customers", customerCount);

            // Retrieve the average number of accounts per customer
            query = "SELECT AVG(AccountCount) as avg FROM (SELECT COUNT(*) AS AccountCount FROM Account GROUP BY SSN)";
            command = new SQLiteCommand(query, connection.myConnection);
            reader = command.ExecuteReader();
            string avgAccounts = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    avgAccounts = reader["avg"].ToString();
                }

            }

            dataGridView.Rows.Add("Average number of accounts per customer", avgAccounts);

            // Retrieve the average number of loans per customer
            query = "SELECT AVG(LoanCount) as avg FROM (SELECT COUNT(*) AS LoanCount FROM Loan GROUP BY SSN)";
            command = new SQLiteCommand(query, connection.myConnection);
            reader = command.ExecuteReader();
            string avgLoans = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    avgLoans = reader["avg"].ToString();
                }

            }

            dataGridView.Rows.Add("Average number of loans per customer", avgLoans);

            // Retrieve the average balance of accounts
            query = "SELECT AVG(Balance) as avg FROM Account";
            command = new SQLiteCommand(query, connection.myConnection);
            reader = command.ExecuteReader();
            string avgBalance = "0";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    avgBalance = reader["avg"].ToString();
                }

            }

            dataGridView.Rows.Add("Average balance of accounts", avgBalance);

            connection.CloseConnection();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {

        }
    }
}
