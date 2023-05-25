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
    public partial class LoanData : UserControl
    {
        public LoanData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = $@"SELECT l2.Lnumber AS [Loan Number], l2.Amount, l2.Type, l2.Status, l2.Name AS [Customer Name], u2.Name AS [Employee Name]
                            FROM
                                (SELECT Lnumber, Amount, EmpSSN, l.Type, l.Status, Name
                                FROM User u1
                                JOIN Loan l ON u1.SSN = {SessionManager.SSN} AND u1.SSN = l.SSN) l2
                            LEFT JOIN User u2 ON l2.EmpSSN = u2.SSN;
                            ";

            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();


            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable loanTypeTable = new DataTable();
            adapter.Fill(loanTypeTable);
            TakenLoansDataGrid.DataSource = loanTypeTable;

            databaseObject.CloseConnection();
        }

        private void LoanData_Load(object sender, EventArgs e)
        {

        }
    }
}
