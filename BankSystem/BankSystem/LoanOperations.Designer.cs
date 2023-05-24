namespace BankSystem
{
    partial class LoanOperations
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoanTypeComboBox = new ComboBox();
            BranchNumberBox = new TextBox();
            BranchNo = new Label();
            label2 = new Label();
            LoanValueTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 122);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 0;
            label1.Text = "Loan Type";
            // 
            // LoanTypeComboBox
            // 
            LoanTypeComboBox.FormattingEnabled = true;
            LoanTypeComboBox.Location = new Point(359, 131);
            LoanTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            LoanTypeComboBox.Name = "LoanTypeComboBox";
            LoanTypeComboBox.Size = new Size(188, 23);
            LoanTypeComboBox.TabIndex = 1;
            LoanTypeComboBox.SelectedIndexChanged += LoanTypeComboBox_SelectedIndexChanged;
            // 
            // BranchNumberBox
            // 
            BranchNumberBox.Location = new Point(359, 49);
            BranchNumberBox.Margin = new Padding(3, 2, 3, 2);
            BranchNumberBox.Name = "BranchNumberBox";
            BranchNumberBox.Size = new Size(188, 23);
            BranchNumberBox.TabIndex = 2;
            BranchNumberBox.TextChanged += BranchNumberBox_TextChanged;
            // 
            // BranchNo
            // 
            BranchNo.AutoSize = true;
            BranchNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BranchNo.Location = new Point(84, 38);
            BranchNo.Name = "BranchNo";
            BranchNo.Size = new Size(194, 32);
            BranchNo.TabIndex = 3;
            BranchNo.Text = "Branch Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 204);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 4;
            label2.Text = "Loan Value";
            // 
            // LoanValueTextBox
            // 
            LoanValueTextBox.Location = new Point(359, 214);
            LoanValueTextBox.Margin = new Padding(3, 2, 3, 2);
            LoanValueTextBox.Name = "LoanValueTextBox";
            LoanValueTextBox.Size = new Size(188, 23);
            LoanValueTextBox.TabIndex = 5;
            LoanValueTextBox.TextChanged += LoanValueTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(274, 272);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoanOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(LoanValueTextBox);
            Controls.Add(label2);
            Controls.Add(BranchNo);
            Controls.Add(BranchNumberBox);
            Controls.Add(LoanTypeComboBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoanOperations";
            Text = "LoanOperations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox LoanTypeComboBox;
        private TextBox BranchNumberBox;
        private Label BranchNo;
        private Label label2;
        private TextBox LoanValueTextBox;
        private Button button1;
    }
}