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
            ErrorLabel.Text = "";
            Database databaseObject = new Database();

            string query = "SELECT SSN, Password, Type, Bnumber, Name FROM User";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            databaseObject.OpenConnection();

            SQLiteDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string snn = reader["SSN"].ToString();
                    string password = reader["Password"].ToString();
                    string type = reader["Type"].ToString();
                    if (snn == SNNBox.Text)
                    {
                        if (password != PasswordBox.Text)
                        {
                            ErrorLabel.Text = "The Password isn't correct";
                        }
                        else
                        {
                            SessionManager.Name = reader["Name"].ToString();
                            SessionManager.branchNumber = reader["Bnumber"].ToString();
                            SessionManager.SSN = reader["SSN"].ToString();
                            if (type == "Admin")
                            {
                                ErrorLabel.Text = "";
                                SNNBox.Text = "";
                                PasswordBox.Text = "";
                                UserControl adminHome = new AdminHome();
                                this.Controls.Add(adminHome);
                                adminHome.BringToFront();
                            }
                            else if (type == "Employee")
                            {
                                ErrorLabel.Text = "";
                                SNNBox.Text = "";
                                PasswordBox.Text = "";
                                UserControl employeeHome = new EmployeeHome();
                                this.Controls.Add(employeeHome);
                                employeeHome.BringToFront();

                            }
                            else if (type == "Customer")
                            {
                                ErrorLabel.Text = "";
                                SNNBox.Text = "";
                                PasswordBox.Text = "";
                                UserControl customerHome = new CustomerHome();
                                this.Controls.Add(customerHome);
                                customerHome.BringToFront();
                            }
                        }
                        reader.Close();
                        databaseObject.CloseConnection();
                        return;
                    }
                }
            }
            ErrorLabel.Text = "User not fount";
            PasswordBox.Text = "";
            reader.Close();
            databaseObject.CloseConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserControl registerForm = new Register();
            this.Controls.Add(registerForm);
            registerForm.BringToFront();

        }

        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
