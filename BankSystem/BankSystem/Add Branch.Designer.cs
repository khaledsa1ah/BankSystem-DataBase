namespace BankSystem
{
    partial class Add_Branch
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
            label5 = new Label();
            label1 = new Label();
            AddressBox = new TextBox();
            addBranchButton = new Button();
            NameError = new Label();
            NameBox = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(314, 313);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(314, 408);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 16;
            label5.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 237);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 13;
            label1.Text = "Add New Branch";
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(314, 432);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(398, 32);
            AddressBox.TabIndex = 12;
            // 
            // addBranchButton
            // 
            addBranchButton.BackColor = Color.Tomato;
            addBranchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBranchButton.ForeColor = Color.Transparent;
            addBranchButton.Location = new Point(444, 505);
            addBranchButton.Name = "addBranchButton";
            addBranchButton.Size = new Size(141, 41);
            addBranchButton.TabIndex = 9;
            addBranchButton.Text = "Add Branch";
            addBranchButton.UseVisualStyleBackColor = false;
            addBranchButton.Click += button1_Click;
            // 
            // NameError
            // 
            NameError.AutoSize = true;
            NameError.ForeColor = Color.Red;
            NameError.Location = new Point(324, 378);
            NameError.Name = "NameError";
            NameError.Size = new Size(0, 15);
            NameError.TabIndex = 17;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.FormattingEnabled = true;
            NameBox.Location = new Point(314, 337);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(271, 38);
            NameBox.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(602, 337);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 19;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Add_Branch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(NameBox);
            Controls.Add(NameError);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressBox);
            Controls.Add(addBranchButton);
            Name = "Add_Branch";
            Size = new Size(800, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox AddressBox;
        private Button addBranchButton;
        private Label NameError;
        private ComboBox NameBox;
        private Button button1;
    }
}
