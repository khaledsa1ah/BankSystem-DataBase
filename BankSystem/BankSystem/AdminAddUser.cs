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
    public partial class AdminAddUser : UserControl
    {
        public AdminAddUser()
        {
            InitializeComponent();
            FillForm();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            string name = NameBox.Text;
            string ssn = SNNBox.Text;
            string password = PasswordBox.Text;
            string address = AddressBox.Text;
            int bankNumber = int.Parse(BankNumberBox.Text);
            string phone = PhoneNumberBox.Text;
            string type = comboBox1.Text;

            // Create a new SQLite command
            string query = "INSERT INTO User (Name, SSN, Password, Type, Address, Bnumber) VALUES (@name, @SSN, @password, @type, @address, @bankNumber)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            string query2 = "SELECT SSN FROM User";
            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);

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
                        comboBox1.Text = "";
                        MessageBox.Show("The user is alreay available before.");
                        reader.Close();
                        databaseObject.CloseConnection();
                        return;
                    }
                }
            }
            if (name == "" || ssn == "" || password == "" || address == "" || phone == "" || type == "")
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
            databaseObject.OpenConnection();
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
            comboBox1.Text = "";
            MessageBox.Show("User has been added successfully!");
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void BankNumberBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SNNBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void AdminAddUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillForm();
        }
    }
}
