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
            string query = "INSERT INTO User (Name, SSN, Password, Type, Address, Bnumber) VALUES (@name, @SSN, @password, @type, @address, @bankNumber)";
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

            string query2 = "SELECT SSN FROM User";
            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection)
                ;
            databaseObject.OpenConnection();
            // Retrieve values from the input fields
            SQLiteDataReader reader = myCommand2.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (ssn == reader["SSN"].ToString())
                    {
                        NameBox.Text = "";
                        SNNBox.Text = "";
                        PasswordBox.Text = "";
                        AddressBox.Text = "";
                        BankNumberBox.Text = "";
                        PhoneNumberBox.Text = "";
                        MessageBox.Show("The Customer is alreay available before.");
                        databaseObject.CloseConnection();
                        return;
                    }
                }
            }
            if (name == "" || ssn == "" || password == "" || address == "" || bankNumber == "" || phone == "" || type == "")
            {
                MessageBox.Show("You should fill all empty places.");
                reader.Close();
                databaseObject.CloseConnection();
                return;

            }
            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@SSN", ssn);
            myCommand.Parameters.AddWithValue("@password", password);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@address", address);
            myCommand.Parameters.AddWithValue("@bankNumber", bankNumber);


            // Execute the query
            myCommand.ExecuteNonQuery();

            query = "INSERT INTO User_Phone (SSN, Phone) VALUES (@SSN, @phone)";
            myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@phone", phone);
            myCommand.Parameters.AddWithValue("@SSN", ssn);


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
            this.Parent.Controls.Remove(this);
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
