using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class EmployeeHome : UserControl
    {
        UserControl addCustomer = new EmployeeAddCustomer();
        UserControl viewCustomers = new ViewCustomers();
        UserControl Loans = new LoanEmployeeOperations();
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(viewCustomers);
            this.Controls.Remove(Loans);
            this.Controls.Add(addCustomer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(viewCustomers);
            this.Controls.Remove(addCustomer);
            this.Controls.Remove(Loans);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(viewCustomers);
            this.Controls.Remove(addCustomer);
            this.Controls.Add(Loans);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {

        }
    }
}
