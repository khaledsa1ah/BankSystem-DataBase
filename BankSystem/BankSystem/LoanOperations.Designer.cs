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
            label1.Location = new Point(126, 162);
            label1.Name = "label1";
            label1.Size = new Size(161, 41);
            label1.TabIndex = 0;
            label1.Text = "Loan Type";
            // 
            // LoanTypeComboBox
            // 
            LoanTypeComboBox.FormattingEnabled = true;
            LoanTypeComboBox.Location = new Point(410, 175);
            LoanTypeComboBox.Name = "LoanTypeComboBox";
            LoanTypeComboBox.Size = new Size(214, 28);
            LoanTypeComboBox.TabIndex = 1;
            // 
            // BranchNumberBox
            // 
            BranchNumberBox.Location = new Point(410, 65);
            BranchNumberBox.Name = "BranchNumberBox";
            BranchNumberBox.Size = new Size(214, 27);
            BranchNumberBox.TabIndex = 2;
            // 
            // BranchNo
            // 
            BranchNo.AutoSize = true;
            BranchNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BranchNo.Location = new Point(96, 51);
            BranchNo.Name = "BranchNo";
            BranchNo.Size = new Size(239, 41);
            BranchNo.TabIndex = 3;
            BranchNo.Text = "Branch Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 272);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 4;
            label2.Text = "Loan Value";
            // 
            // LoanValueTextBox
            // 
            LoanValueTextBox.Location = new Point(410, 286);
            LoanValueTextBox.Name = "LoanValueTextBox";
            LoanValueTextBox.Size = new Size(214, 27);
            LoanValueTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(313, 363);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoanOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LoanValueTextBox);
            Controls.Add(label2);
            Controls.Add(BranchNo);
            Controls.Add(BranchNumberBox);
            Controls.Add(LoanTypeComboBox);
            Controls.Add(label1);
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