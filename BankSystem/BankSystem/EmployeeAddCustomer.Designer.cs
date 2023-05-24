namespace BankSystem
{
    partial class EmployeeAddCustomer
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
            BankNumberBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(349, 526);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 29;
            label7.Text = "Branch Number";
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = SystemColors.WindowText;
            PasswordBox.Location = new Point(349, 333);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(398, 35);
            PasswordBox.TabIndex = 27;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(467, 105);
            label6.Name = "label6";
            label6.Size = new Size(178, 32);
            label6.TabIndex = 26;
            label6.Text = "Add Customer";
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Tomato;
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBTN.ForeColor = Color.Snow;
            AddBTN.Location = new Point(413, 634);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(269, 52);
            AddBTN.TabIndex = 25;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(349, 448);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 24;
            label5.Text = "PhoneNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(350, 376);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 23;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(349, 309);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(350, 238);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 21;
            label2.Text = "SSN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(349, 169);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 20;
            label1.Text = "Name";
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberBox.Location = new Point(350, 472);
            PhoneNumberBox.Multiline = true;
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(398, 35);
            PhoneNumberBox.TabIndex = 18;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(350, 400);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 35);
            AddressBox.TabIndex = 19;
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.Location = new Point(349, 262);
            SNNBox.Multiline = true;
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(398, 35);
            SNNBox.TabIndex = 17;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(350, 193);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 35);
            NameBox.TabIndex = 16;
            // 
            // BankNumberBox
            // 
            BankNumberBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BankNumberBox.FormattingEnabled = true;
            BankNumberBox.Location = new Point(350, 566);
            BankNumberBox.Name = "BankNumberBox";
            BankNumberBox.Size = new Size(264, 33);
            BankNumberBox.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(620, 566);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 31;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmployeeAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(BankNumberBox);
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
            Name = "EmployeeAddCustomer";
            Size = new Size(800, 800);
            Load += EmployeeAddCustomer_Load;
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
        private ComboBox BankNumberBox;
        private Button button1;
    }
}
