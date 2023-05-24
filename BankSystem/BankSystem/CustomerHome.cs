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
    public partial class CustomerHome : UserControl
    {
        UserControl loanRequest = new LoanRequest();
        UserControl viewLoans = new LoanData();
        UserControl loanTypes = new LoanTypesView();
        UserControl addAccount = new AddAccount();
        UserControl ViewAccounts = new ViewAccounts();

        public CustomerHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(loanRequest);
            this.Controls.Remove(viewLoans);
            this.Controls.Remove(loanTypes);
            this.Controls.Remove(ViewAccounts);
            this.Controls.Add(addAccount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(loanRequest);
            this.Controls.Remove(viewLoans);
            this.Controls.Remove(loanTypes);
            this.Controls.Remove(ViewAccounts);
            this.Controls.Remove(addAccount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(loanRequest);
            this.Controls.Add(viewLoans);
            this.Controls.Remove(loanTypes);
            this.Controls.Remove(ViewAccounts);
            this.Controls.Remove(addAccount);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(loanRequest);
            this.Controls.Remove(viewLoans);
            this.Controls.Add(loanTypes);
            this.Controls.Remove(ViewAccounts);
            this.Controls.Remove(addAccount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(loanRequest);
            this.Controls.Remove(viewLoans);
            this.Controls.Remove(loanTypes);
            this.Controls.Add(ViewAccounts);
            this.Controls.Remove(addAccount);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {

        }
    }
}
