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


            // Create a new SQLite command
            string query = "INSERT INTO Bank(Name, Code, Address) VALUES (@name, @code, @address)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            // Retrieve values from the input fields
            string name = NameBox.Text;
            string code = CodeBox.Text;
            string address = AddressBox.Text;

            //Checking if the name and code was entered before or not

            string query2 = "SELECT Name FROM Bank";

            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);


            SQLiteDataReader reader = myCommand2.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (name == reader["Name"].ToString())
                    {
                        // Show Error Message for Name
                        NameError.Text = "You have entered this bank before";
                        return;
                    }
                }
            }


            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            myCommand.Parameters.AddWithValue("@address", address);


            // Execute the query
            myCommand.ExecuteNonQuery();


            // Close the connection
            databaseObject.CloseConnection();

            NameBox.Text = "";
            CodeBox.Text = "";
            AddressBox.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
