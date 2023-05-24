using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class AdminHome : UserControl
    {
        public UserControl Bank = new AddBank();
        public UserControl Branch = new Add_Branch();
        public UserControl BanksData = new BankData();
        public UserControl branchsData = new BranchData();
        public UserControl AddUser = new AdminAddUser();
        public UserControl View = new ViewUsers();
        public UserControl Report = new report();
        public AdminHome()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Bank);
            this.Controls.Remove(BanksData);
            this.Controls.Add(AddUser);
            this.Controls.Remove(Branch);
            this.Controls.Remove(Report);
            this.Controls.Remove(branchsData);
        }

        //Add Branch Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Bank);
            this.Controls.Remove(BanksData);
            this.Controls.Remove(AddUser);
            this.Controls.Add(Branch);
            this.Controls.Remove(Report);
            this.Controls.Remove(branchsData);
        }


        //Add Bank Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Branch);
            this.Controls.Remove(BanksData);
            this.Controls.Remove(AddUser);
            this.Controls.Add(Bank);
            this.Controls.Remove(Report);
            this.Controls.Remove(branchsData);
        }



        //View Bank Data Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Branch);
            this.Controls.Remove(Bank);
            this.Controls.Remove(AddUser);
            this.Controls.Add(BanksData);
            this.Controls.Remove(Report);
            this.Controls.Remove(branchsData);
        }

        private void addBank1_Load(object sender, EventArgs e)
        {

        }

        private void add_Branch1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bankData1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Add(View);
            this.Controls.Remove(Branch);
            this.Controls.Remove(Bank);
            this.Controls.Remove(AddUser);
            this.Controls.Remove(BanksData);
            this.Controls.Remove(Report);
            this.Controls.Remove(branchsData);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Branch);
            this.Controls.Remove(Bank);
            this.Controls.Remove(AddUser);
            this.Controls.Remove(BanksData);
            this.Controls.Remove(branchsData);
            this.Controls.Add(Report);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(View);
            this.Controls.Remove(Bank);
            this.Controls.Remove(BanksData);
            this.Controls.Remove(AddUser);
            this.Controls.Remove(Branch);
            this.Controls.Remove(Report);
            this.Controls.Add(branchsData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
