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
    public partial class HomePage : UserControl
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            string query = "SELECT SNN, Password FROM User";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();

            SQLiteDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string snn = reader["SNN"].ToString();
                    string password = reader["Password"].ToString();

                    if (snn == SNNBox.Text)
                    {
                        if(password != PasswordBox.Text)
                        {
                            ErrorLabel.Text = "The Password isn't correct";
                        }
                        else
                        {
                            ErrorLabel.Text = "The Password is correct";
                        }
                        reader.Close();
                        databaseObject.CloseConnection();
                        return;
                    }
                }
            }
            ErrorLabel.Text = "User not fount";
            reader.Close();
            databaseObject.CloseConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
