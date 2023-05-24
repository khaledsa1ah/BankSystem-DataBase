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
    public partial class BranchData : UserControl
    {
        public BranchData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            string query2 = "SELECT * FROM Branch";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, databaseObject.myConnection);


            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter();
            adapter2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            BranchDataGrid.DataSource = dt2;


            databaseObject.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BranchDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BranchDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BranchDataGrid.SelectedRows[0];

                string Bnumber = selectedRow.Cells["Bnumber"].Value.ToString();
                string query = "DELETE FROM Branch Where Bnumber = @Bnumber";
                Database database = new Database();
                database.OpenConnection();
                SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@Bnumber", Bnumber);
                myCommand.ExecuteNonQuery();
                query = "DELETE FROM User Where Bnumber = @Bnumber";
                myCommand = new SQLiteCommand(query, database.myConnection);
                myCommand.Parameters.AddWithValue("@Bnumber", Bnumber);
                myCommand.ExecuteNonQuery();
                database.CloseConnection();
                MessageBox.Show("This Branch has been deleted!. Refresh to see updates");

            }
        }

        private void BranchData_Load(object sender, EventArgs e)
        {

        }
    }
}
