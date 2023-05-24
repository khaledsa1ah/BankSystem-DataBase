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
    public partial class AddBank : UserControl
    {
        public AddBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Database databaseObject = new Database();

            databaseObject.OpenConnection();

            NameError.Text = "";

            // Create a new SQLite command
            string query = "INSERT INTO Bank(Name, Code, Address) VALUES (@name, @code, @address)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);


            // Retrieve values from the input fields
            string name = NameBox.Text;
            string code = CodeBox.Text;
            string address = AddressBox.Text;

            //Checking if the name and code was entered before or not

            string query2 = "SELECT Name FROM Bank WHERE Name = @name";

            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);

            myCommand2.Parameters.AddWithValue("@name", name);
            SQLiteDataReader reader = myCommand2.ExecuteReader();


            if (reader.HasRows)
            {
                // Show Error Message for Name
                NameError.Text = "You have entered this bank before";
                reader.Close();
                databaseObject.CloseConnection();
                return;

            }


            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            myCommand.Parameters.AddWithValue("@address", address);


            // Execute the query
            myCommand.ExecuteNonQuery();
            reader.Close();

            // Close the connection
            databaseObject.CloseConnection();

            NameBox.Text = "";
            CodeBox.Text = "";
            AddressBox.Text = "";
            MessageBox.Show("Bank has been added successfully!");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBank_Load(object sender, EventArgs e)
        {

        }
    }
}
