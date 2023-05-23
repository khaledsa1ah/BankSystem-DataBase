namespace BankSystem
{
    partial class AddBank
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
            Label label2;
            button1 = new Button();
            NameBox = new TextBox();
            CodeBox = new TextBox();
            AddressBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            NameError = new Label();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 309);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(221, 535);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 0;
            button1.Text = "Add Bank";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(130, 333);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(398, 29);
            NameBox.TabIndex = 1;
            // 
            // CodeBox
            // 
            CodeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBox.Location = new Point(130, 407);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(398, 29);
            CodeBox.TabIndex = 2;
            CodeBox.TextChanged += textBox2_TextChanged;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(130, 470);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 29);
            AddressBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 260);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 4;
            label1.Text = "Add New Bank";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 383);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 6;
            label3.Text = "Code";
            // 
            // NameError
            // 
            NameError.AutoSize = true;
            NameError.ForeColor = Color.Red;
            NameError.Location = new Point(130, 365);
            NameError.Name = "NameError";
            NameError.Size = new Size(0, 15);
            NameError.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(130, 446);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // AddBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(NameError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressBox);
            Controls.Add(CodeBox);
            Controls.Add(NameBox);
            Controls.Add(button1);
            Name = "AddBank";
            Size = new Size(800, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox NameBox;
        private TextBox CodeBox;
        private TextBox AddressBox;
        private Label label1;
        private Label label3;
        private Label NameError;
        private Label label5;
    }
}
