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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem
{
    public partial class EmployeeAddCustomer : UserControl
    {
        public EmployeeAddCustomer()
        {
            InitializeComponent();
            FillForm();
        }

        private void AddBTN_Click(object sender, EventArgs e)
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
            string bankNumber = SessionManager.branchNumber;
            string phone = PhoneNumberBox.Text;
            // Add parameters to the command

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
            MessageBox.Show("Customer has been added successfully!");
        }
        private void FillForm()
        {
            Database databaseObject = new Database();


            string bnum = SessionManager.branchNumber;
            // Create a new SQLite command
            string query = $"SELECT Bnumber FROM Branch";
            databaseObject.OpenConnection();

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            SQLiteDataReader reader = myCommand.ExecuteReader();

            List<string> selectedEntries = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string entry = reader.GetInt32(0).ToString();
                    selectedEntries.Add(entry);
                }

                BankNumberBox.Items.Clear();
                foreach (string entry in selectedEntries)
                {
                    BankNumberBox.Items.Add(entry);
                }
            }
            // Close the connection
            databaseObject.CloseConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillForm();
        }

        private void EmployeeAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
