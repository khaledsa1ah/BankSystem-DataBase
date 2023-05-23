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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();


            // Create a new SQLite command
            string query = "INSERT INTO Branch(Name, Bnumber, Address) VALUES (@name, @Bnumber, @address)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            // Retrieve values from the input fields
            string name = NameBox.Text;
            string Bnumber = BnumberBox.Text;
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
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    if (Bnumber == reader2["Bnumber"].ToString() )
                    {
                        numberFlag = true;
                    }
                }
            }


            //if the entered bank name is not in Table Bank
            if (nameFlag == false)
            {
                // Show Error Message for Name
                NameError.Text = "There is no bank with that name in the database";
                return;
            }

            //if the entered branch number is in Table Branch
            if (numberFlag == true)
            {
                // Show Error Message for Bnumber
                BnumberError.Text = "There is already a branch with that  number ";
                return;
            }



            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@Bnumber", Bnumber);
            myCommand.Parameters.AddWithValue("@address", address);


            // Execute the query
            myCommand.ExecuteNonQuery();


            // Close the connection
            databaseObject.CloseConnection();

            NameBox.Text = "";
            BnumberBox.Text = "";
            AddressBox.Text = "";

        }
    }
}
