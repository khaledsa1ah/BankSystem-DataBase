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
            PasswordBox = new TextBox();
            AddressBox = new TextBox();
            PhoneNumberBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RegisterBTN = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(155, 174);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 35);
            NameBox.TabIndex = 0;
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.Location = new Point(154, 243);
            SNNBox.Multiline = true;
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(398, 35);
            SNNBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(155, 314);
            PasswordBox.Multiline = true;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(398, 35);
            PasswordBox.TabIndex = 11;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(155, 381);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 35);
            AddressBox.TabIndex = 4;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberBox.Location = new Point(155, 445);
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
            label1.Location = new Point(154, 150);
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
            label2.Location = new Point(155, 219);
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
            label3.Location = new Point(154, 290);
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
            label4.Location = new Point(155, 357);
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
            label5.Location = new Point(154, 421);
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
            RegisterBTN.Location = new Point(217, 518);
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
            label6.Location = new Point(272, 85);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 11;
            label6.Text = "Registeration";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label6);
            Controls.Add(RegisterBTN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumberBox);
            Controls.Add(AddressBox);
            Controls.Add(PasswordBox);
            Controls.Add(SNNBox);
            Controls.Add(NameBox);
            Name = "Register";
            Size = new Size(723, 672);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox SNNBox;
        private TextBox PasswordBox;
        private TextBox AddressBox;
        private TextBox PhoneNumberBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button RegisterBTN;
        private Label label6;
    }
}
