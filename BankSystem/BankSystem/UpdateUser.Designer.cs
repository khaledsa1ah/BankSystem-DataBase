namespace BankSystem
{
    partial class UpdateUser
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
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            BankNumberBox = new TextBox();
            label6 = new Label();
            AddBTN = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SNNBox = new TextBox();
            NameBox = new TextBox();
            AddressBox = new TextBox();
            BackBTN = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(339, 456);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 61;
            label8.Text = "Type";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Customer", "Employee" });
            comboBox1.Location = new Point(338, 490);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(397, 33);
            comboBox1.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(338, 375);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 59;
            label7.Text = "Bank Number";
            // 
            // BankNumberBox
            // 
            BankNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BankNumberBox.Location = new Point(338, 399);
            BankNumberBox.Multiline = true;
            BankNumberBox.Name = "BankNumberBox";
            BankNumberBox.Size = new Size(398, 35);
            BankNumberBox.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(457, 74);
            label6.Name = "label6";
            label6.Size = new Size(154, 32);
            label6.TabIndex = 56;
            label6.Text = "Update User";
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Tomato;
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBTN.ForeColor = Color.Snow;
            AddBTN.Location = new Point(338, 564);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(175, 52);
            AddBTN.TabIndex = 55;
            AddBTN.Text = "Update User";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(338, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 53;
            label4.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(338, 198);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 51;
            label2.Text = "SSN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(337, 129);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 50;
            label1.Text = "Name";
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.Location = new Point(337, 222);
            SNNBox.Multiline = true;
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(398, 35);
            SNNBox.TabIndex = 47;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(338, 153);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 35);
            NameBox.TabIndex = 46;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(338, 302);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 35);
            AddressBox.TabIndex = 49;
            // 
            // BackBTN
            // 
            BackBTN.BackColor = Color.DodgerBlue;
            BackBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBTN.ForeColor = Color.Snow;
            BackBTN.Location = new Point(561, 564);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(175, 52);
            BackBTN.TabIndex = 62;
            BackBTN.Text = "Back";
            BackBTN.UseVisualStyleBackColor = false;
            BackBTN.Click += BackBTN_Click;
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackBTN);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(BankNumberBox);
            Controls.Add(label6);
            Controls.Add(AddBTN);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressBox);
            Controls.Add(SNNBox);
            Controls.Add(NameBox);
            Name = "UpdateUser";
            Size = new Size(800, 800);
            Load += UpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox BankNumberBox;
        private Label label6;
        private Button AddBTN;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox SNNBox;
        private TextBox NameBox;
        private TextBox AddressBox;
        private Button BackBTN;
    }
}
