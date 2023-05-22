namespace BankSystem
{
    partial class Register
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
            NameBox = new TextBox();
            SNNBox = new TextBox();
            AddressBox = new TextBox();
            PhoneNumberBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RegisterBTN = new Button();
            label6 = new Label();
            button1 = new Button();
            PasswordBox = new TextBox();
            label7 = new Label();
            BankNumberBox = new TextBox();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(212, 180);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 35);
            NameBox.TabIndex = 0;
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.Location = new Point(211, 249);
            SNNBox.Multiline = true;
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(398, 35);
            SNNBox.TabIndex = 1;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(212, 387);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 35);
            AddressBox.TabIndex = 4;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberBox.Location = new Point(212, 459);
            PhoneNumberBox.Multiline = true;
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(398, 35);
            PhoneNumberBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(211, 156);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 5;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(212, 225);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 6;
            label2.Text = "SNN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(211, 296);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(212, 363);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(211, 435);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 9;
            label5.Text = "PhoneNumber";
            label5.Click += label5_Click;
            // 
            // RegisterBTN
            // 
            RegisterBTN.BackColor = Color.Tomato;
            RegisterBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBTN.ForeColor = Color.Snow;
            RegisterBTN.Location = new Point(275, 606);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(269, 52);
            RegisterBTN.TabIndex = 10;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = false;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(329, 91);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 11;
            label6.Text = "Registeration";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(275, 673);
            button1.Name = "button1";
            button1.Size = new Size(269, 52);
            button1.TabIndex = 12;
            button1.Text = "Back to Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = SystemColors.WindowText;
            PasswordBox.Location = new Point(211, 320);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(398, 35);
            PasswordBox.TabIndex = 13;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Tomato;
            label7.Location = new Point(211, 513);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 15;
            label7.Text = "Bank Number";
            label7.Click += label7_Click;
            // 
            // BankNumberBox
            // 
            BankNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BankNumberBox.Location = new Point(211, 537);
            BankNumberBox.Multiline = true;
            BankNumberBox.Name = "BankNumberBox";
            BankNumberBox.Size = new Size(398, 35);
            BankNumberBox.TabIndex = 14;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(BankNumberBox);
            Controls.Add(PasswordBox);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(RegisterBTN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumberBox);
            Controls.Add(AddressBox);
            Controls.Add(SNNBox);
            Controls.Add(NameBox);
            Name = "Register";
            Size = new Size(800, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox SNNBox;
        private TextBox AddressBox;
        private TextBox PhoneNumberBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button RegisterBTN;
        private Label label6;
        private Button button1;
        private TextBox PasswordBox;
        private Label label7;
        private TextBox BankNumberBox;
    }
}
