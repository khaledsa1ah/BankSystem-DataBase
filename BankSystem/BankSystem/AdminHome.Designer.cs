namespace BankSystem
{
    partial class AdminHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            addBank1 = new AddBank();
            add_Branch1 = new Add_Branch();
            bankData1 = new BankData();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 800);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(46, 529);
            button5.Name = "button5";
            button5.Size = new Size(141, 41);
            button5.TabIndex = 6;
            button5.Text = "View Banks Data";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(46, 703);
            button4.Name = "button4";
            button4.Size = new Size(141, 41);
            button4.TabIndex = 5;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(46, 458);
            button3.Name = "button3";
            button3.Size = new Size(141, 41);
            button3.TabIndex = 4;
            button3.Text = "Add User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(46, 386);
            button2.Name = "button2";
            button2.Size = new Size(141, 41);
            button2.TabIndex = 3;
            button2.Text = "Add Branch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(46, 313);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 2;
            button1.Text = "Add Bank";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(84, 176);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\over-\\Github projects\\BankSystem-DataBase\\BankSystem\\BankSystem\\user.png";
            pictureBox1.Location = new Point(62, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addBank1
            // 
            addBank1.Location = new Point(239, 0);
            addBank1.Name = "addBank1";
            addBank1.Size = new Size(561, 800);
            addBank1.TabIndex = 1;
            addBank1.Load += addBank1_Load;
            // 
            // add_Branch1
            // 
            add_Branch1.Location = new Point(236, 0);
            add_Branch1.Name = "add_Branch1";
            add_Branch1.Size = new Size(561, 800);
            add_Branch1.TabIndex = 2;
            add_Branch1.Load += add_Branch1_Load;
            // 
            // bankData1
            // 
            bankData1.Location = new Point(236, 0);
            bankData1.Name = "bankData1";
            bankData1.Size = new Size(564, 800);
            bankData1.TabIndex = 3;
            bankData1.Load += bankData1_Load;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bankData1);
            Controls.Add(add_Branch1);
            Controls.Add(addBank1);
            Controls.Add(panel1);
            Name = "AdminHome";
            Size = new Size(800, 800);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private AddBank addBank1;
        private Add_Branch add_Branch1;
        private Button button5;
        private BankData bankData1;
    }
}
