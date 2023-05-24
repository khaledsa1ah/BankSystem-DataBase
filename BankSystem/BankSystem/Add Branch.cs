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
    public partial class Add_Branch : UserControl
    {
        public Add_Branch()
        {
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            Database databaseObject = new Database();


            string bnum = SessionManager.branchNumber;
            // Create a new SQLite command
            string query = $"SELECT Name FROM Bank";
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

                NameBox.Items.Clear();
                foreach (string entry in selectedEntries)
                {
                    NameBox.Items.Add(entry);
                }
            }
            // Close the connection
            reader.Close();
            databaseObject.CloseConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();


            // Create a new SQLite command
            string query = "INSERT INTO Branch(Name, Address) VALUES (@name, @address)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);



            // Retrieve values from the input fields
            string name = NameBox.Text;
            string address = AddressBox.Text;

            //Checking if there is a bank with that name or not

            string query2 = "SELECT Name FROM Bank";

            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);

            //Checking if the Bnumber of the specific bank was enterd before or not

            string query3 = "SELECT Bnumber FROM Branch";

            SQLiteCommand myCommand3 = new SQLiteCommand(query3, databaseObject.myConnection);


            SQLiteDataReader reader = myCommand2.ExecuteReader();

            bool nameFlag = false;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (name == reader["Name"].ToString())
                    {
                        nameFlag = true;
                    }
                }
            }

            SQLiteDataReader reader2 = myCommand3.ExecuteReader();

            bool numberFlag = false;



            //if the entered bank name is not in Table Bank
            if (nameFlag == false)
            {
                // Show Error Message for Name
                NameError.Text = "There is no bank with that name in the database";
                reader.Close();
                reader2.Close();
                databaseObject.CloseConnection();
                return;
            }

            //if the entered branch number is in Table Branch



            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@address", address);


            // Execute the query

            myCommand.ExecuteNonQuery();
            reader.Close();
            reader2.Close();
            // Close the connection
            databaseObject.CloseConnection();

            NameBox.Text = "";
            AddressBox.Text = "";
            MessageBox.Show("Branch has been added successfully!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillForm();
        }
    }
}
