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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            databaseObject.OpenConnection();

            // Create a new SQLite command
            string query = "INSERT INTO User (Name, SNN, Password, Type, Address, Bnumber) VALUES (@name, @SNN, @password, @type, @address,@phonenumber )";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            // Retrieve values from the input fields
            string name = NameBox.Text;
            string ssn = SNNBox.Text;
            string password = PasswordBox.Text;
            string type = "Customer";
            string address = AddressBox.Text;
            string phonenumber = PhoneNumberBox.Text;

            // Validate the password using a regular expression
            bool isPasswordValid = Regex.IsMatch(password, "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[!@#$%^&*])[A-Za-z\\d!@#$%^&*]{8}$");
            if (!isPasswordValid)
            {
                MessageBox.Show("Password must be 8 characters long and contain at least one letter, one number, and one symbol.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop the registration process if the password is invalid
            }

            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@SNN", ssn);
            myCommand.Parameters.AddWithValue("@password", password);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@address", address);
            myCommand.Parameters.AddWithValue("@phonenumber", phonenumber);


            // Execute the query
            myCommand.ExecuteNonQuery();

            // Close the connection
            databaseObject.myConnection.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
