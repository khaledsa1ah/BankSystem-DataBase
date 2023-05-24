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
    public partial class UpdateUser : UserControl
    {
        string SSN;
        public UpdateUser(string[] SelectedRow)
        {
            InitializeComponent();
            SNNBox.Text = SelectedRow[0];
            NameBox.Text = SelectedRow[1];
            AddressBox.Text = SelectedRow[2];
            comboBox1.Text = SelectedRow[3];
            BankNumberBox.Text = SelectedRow[4];
            SSN = SNNBox.Text;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();


            // Create a new SQLite command
            string query = $"UPDATE User SET SSN = @SSN, Name = @name, Type = @type, Address = @address, Bnumber = @bankNumber WHERE SSN = {SSN};";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);


            databaseObject.OpenConnection();
            // Retrieve values from the input fields
            string name = NameBox.Text;
            string ssn = SNNBox.Text;
            string address = AddressBox.Text;
            string bankNumber = BankNumberBox.Text;
            string type = comboBox1.Text;
            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@SSN", ssn);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@address", address);
            myCommand.Parameters.AddWithValue("@bankNumber", bankNumber);


            // Execute the query
            myCommand.ExecuteNonQuery();

            // Close the connection
            databaseObject.CloseConnection();
            MessageBox.Show("The info has been Updated successfully!");
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
