namespace BankSystem
{
    partial class AdminAddUser
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
            label7 = new Label();
            PasswordBox = new TextBox();
            label6 = new Label();
            AddBTN = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PhoneNumberBox = new TextBox();
            AddressBox = new TextBox();
            SNNBox = new TextBox();
            NameBox = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            BankNumberBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(343, 496);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 43;
            label7.Text = "Branch Number";
            label7.Click += label7_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = SystemColors.WindowText;
            PasswordBox.Location = new Point(343, 303);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(398, 35);
            PasswordBox.TabIndex = 41;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(479, 90);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 40;
            label6.Text = "Add User";
            label6.Click += label6_Click;
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Tomato;
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBTN.ForeColor = Color.Snow;
            AddBTN.Location = new Point(412, 671);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(269, 52);
            AddBTN.TabIndex = 39;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(343, 418);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 38;
            label5.Text = "PhoneNumber";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(344, 346);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 37;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(343, 279);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 36;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(344, 208);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 35;
            label2.Text = "SSN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(343, 139);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 34;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberBox.Location = new Point(344, 442);
            PhoneNumberBox.Multiline = true;
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(398, 35);
            PhoneNumberBox.TabIndex = 32;
            PhoneNumberBox.TextChanged += PhoneNumberBox_TextChanged;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(344, 370);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 35);
            AddressBox.TabIndex = 33;
            AddressBox.TextChanged += AddressBox_TextChanged;
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.Location = new Point(343, 232);
            SNNBox.Multiline = true;
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(398, 35);
            SNNBox.TabIndex = 31;
            SNNBox.TextChanged += SNNBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(344, 163);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 35);
            NameBox.TabIndex = 30;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer", "Employee" });
            comboBox1.Location = new Point(343, 611);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(397, 33);
            comboBox1.TabIndex = 44;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(344, 577);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 45;
            label8.Text = "Type";
            label8.Click += label8_Click;
            // 
            // BankNumberBox
            // 
            BankNumberBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BankNumberBox.FormattingEnabled = true;
            BankNumberBox.Location = new Point(343, 530);
            BankNumberBox.Name = "BankNumberBox";
            BankNumberBox.Size = new Size(291, 33);
            BankNumberBox.TabIndex = 46;
            BankNumberBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(640, 530);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 47;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(BankNumberBox);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(PasswordBox);
            Controls.Add(label6);
            Controls.Add(AddBTN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumberBox);
            Controls.Add(AddressBox);
            Controls.Add(SNNBox);
            Controls.Add(NameBox);
            Name = "AdminAddUser";
            Size = new Size(800, 800);
            Load += AdminAddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox PasswordBox;
        private Label label6;
        private Button AddBTN;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PhoneNumberBox;
        private TextBox AddressBox;
        private TextBox SNNBox;
        private TextBox NameBox;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox BankNumberBox;
        private Button button1;
    }
}
