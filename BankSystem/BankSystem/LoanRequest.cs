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
    public partial class LoanRequest : UserControl
    {

        public LoanRequest()
        {
            InitializeComponent();
            FillForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            string lv = LoanValueTextBox.Text;
            double loanValue = Convert.ToDouble(lv);


            string ltype = LoanTypeComboBox.Text;
            string query = "INSERT INTO Loan (Amount, SSN, Type, Status) VALUES (@Amount, @SSN, @Type, @Status)";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();
            myCommand.Parameters.AddWithValue("@Amount", loanValue);
            myCommand.Parameters.AddWithValue("@SSN", SessionManager.SSN);
            myCommand.Parameters.AddWithValue("@Type", ltype);
            myCommand.Parameters.AddWithValue("@Status", "Pending");
            myCommand.ExecuteNonQuery();

            databaseObject.CloseConnection();
            LoanTypeComboBox.Text = "";
            LoanValueTextBox.Text = "";
            MessageBox.Show("Loan has been requested successfully!");
        }

        private void FillForm()
        {
            Database databaseObject = new Database();


            string bnum = SessionManager.branchNumber;
            // Create a new SQLite command
            string query = $"SELECT Type FROM LoanType as lt, Branch as b WHERE b.Bnumber = lt.Bnumber AND b.Bnumber = {bnum}";
            databaseObject.OpenConnection();

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            SQLiteDataReader reader = myCommand.ExecuteReader();

            List<string> selectedEntries = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string entry = reader.GetString(0);
                    selectedEntries.Add(entry);
                }

                LoanTypeComboBox.Items.Clear();
                foreach (string entry in selectedEntries)
                {
                    LoanTypeComboBox.Items.Add(entry);
                }
            }
            // Close the connection
            databaseObject.CloseConnection();
        }

        private void SuccessMessage_Click(object sender, EventArgs e)
        {

        }

        private void LoanRequest_Load(object sender, EventArgs e)
        {

        }

        private void LoanTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
