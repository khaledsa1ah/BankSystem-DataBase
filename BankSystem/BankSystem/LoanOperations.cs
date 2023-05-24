using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BankSystem
{
    public partial class LoanOperations : Form
    {
        public LoanOperations()
        {
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            Database databaseObject = new Database();


            string bnum = BranchNumberBox.Text;
            // Create a new SQLite command
            string query = $"@SELECT lt.Type FROM LoanType as lt,Branch as b WHERE b.Bnumber = lt.Bnumber AND b.Bnumber = {bnum}";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            string lv = LoanValueTextBox.Text;
            double loanValue = Convert.ToDouble(lv);

            databaseObject.OpenConnection();

            string ltype = LoanTypeComboBox.Text;
            string query = $"@INSERT INTO Loan(Amount, EmpSNN, SNN, Type) VALUES ({loanValue}, EmpSNN, SNN,{ltype})";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.ExecuteNonQuery();

            databaseObject.CloseConnection();
        }

        private void BranchNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoanTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoanValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
