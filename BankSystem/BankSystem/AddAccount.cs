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
    public partial class AddAccount : UserControl
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            string query = "INSERT INTO Account (SSN, Balance, Type) VALUES (@SSN, @Balance, @Type)";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();

            myCommand.Parameters.AddWithValue("@SSN", SessionManager.SSN);

            myCommand.Parameters.AddWithValue("@Balance", BalanceBox.Text);

            myCommand.Parameters.AddWithValue("@Type", TypeBox.Text);

            myCommand.ExecuteNonQuery();

            databaseObject.CloseConnection();

            BalanceBox.Text = "";
            TypeBox.Text = "";

        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
