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


            // Create a new SQLite command
            string query = "INSERT INTO User (Name, SNN, Password, Type, Address, Bnumber) VALUES (@name, @SNN, @password, @type, @address, @bankNumber)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            // Retrieve values from the input fields
            string name = NameBox.Text;
            string ssn = SNNBox.Text;
            string password = PasswordBox.Text;
            string type = "Customer";
            string address = AddressBox.Text;
            string bankNumber = BankNumberBox.Text;
            string phone = PhoneNumberBox.Text;
            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@SNN", ssn);
            myCommand.Parameters.AddWithValue("@password", password);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@address", address);
            myCommand.Parameters.AddWithValue("@bankNumber", bankNumber);


            // Execute the query
            myCommand.ExecuteNonQuery();

            query = "INSERT INTO User_Phone (SNN, Phone) VALUES (@SNN, @phone)";
            myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@phone", phone);
            myCommand.Parameters.AddWithValue("@SNN", ssn);


            // Execute the query
            myCommand.ExecuteNonQuery();

            // Close the connection
            databaseObject.CloseConnection();

            NameBox.Text = "";
            SNNBox.Text = "";
            PasswordBox.Text = "";
            AddressBox.Text = "";
            BankNumberBox.Text = "";
            PhoneNumberBox.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
