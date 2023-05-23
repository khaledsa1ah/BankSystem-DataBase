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
        public AdminHome()
        {
            InitializeComponent();

            bankData1.Hide();
            addBank1.Hide();
            add_Branch1.Hide();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        }

        //Add Branch Button
        private void button2_Click(object sender, EventArgs e)
        {
            bankData1.Hide();
            addBank1.Hide();
            add_Branch1.Show();
        }


        //Add Bank Button
        private void button1_Click(object sender, EventArgs e)
        {
            bankData1.Hide();
            add_Branch1.Hide();
            addBank1.Show();
        }

       

        //View Bank Data Button
        private void button5_Click(object sender, EventArgs e)
        {
            addBank1.Hide();
            add_Branch1.Hide();
            bankData1.Show();
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
    }
}
