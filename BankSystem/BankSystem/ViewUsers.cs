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
    public partial class ViewUsers : UserControl
    {
        string[] SelectedCell = new string[6];

        public ViewUsers()
        {
            InitializeComponent();
            FillTable();
        }

        void FillTable()
        {
            Database databaseObject = new Database();

            // Create a new SQLite command
            string query = "SELECT User.SSN, Name, Address, Type, Bnumber as 'Branch Number', Phone FROM User JOIN User_Phone ON User.SSN = User_Phone.SSN";
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UsersDataGrid.DataSource = dt;
            databaseObject.CloseConnection();

        }
        private void LoanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void UsersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UsersDataGrid.Rows.Count)
            {
                DataGridViewRow row = UsersDataGrid.Rows[e.RowIndex];
                SelectedCell[0] = row.Cells["SSN"].Value.ToString();
                SelectedCell[1] = row.Cells["Name"].Value.ToString();
                SelectedCell[2] = row.Cells["Address"].Value.ToString();
                SelectedCell[3] = row.Cells["Type"].Value.ToString();
                SelectedCell[4] = row.Cells["Branch Number"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl updateUser = new UpdateUser(SelectedCell);
            this.Controls.Add(updateUser);
            updateUser.BringToFront();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
