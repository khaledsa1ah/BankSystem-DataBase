namespace BankSystem
{
    partial class LoanRequest
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
            label2 = new Label();
            label3 = new Label();
            LoanValueTextBox = new TextBox();
            LoanTypeComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 335);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Loan Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(357, 419);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Loan Value";
            // 
            // LoanValueTextBox
            // 
            LoanValueTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoanValueTextBox.Location = new Point(487, 408);
            LoanValueTextBox.Name = "LoanValueTextBox";
            LoanValueTextBox.Size = new Size(235, 32);
            LoanValueTextBox.TabIndex = 4;
            // 
            // LoanTypeComboBox
            // 
            LoanTypeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoanTypeComboBox.FormattingEnabled = true;
            LoanTypeComboBox.Location = new Point(487, 329);
            LoanTypeComboBox.Name = "LoanTypeComboBox";
            LoanTypeComboBox.Size = new Size(235, 33);
            LoanTypeComboBox.TabIndex = 5;
            LoanTypeComboBox.SelectedIndexChanged += LoanTypeComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(487, 484);
            button1.Name = "button1";
            button1.Size = new Size(137, 39);
            button1.TabIndex = 6;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoanRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(LoanTypeComboBox);
            Controls.Add(LoanValueTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "LoanRequest";
            Size = new Size(800, 800);
            Load += LoanRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox LoanValueTextBox;
        private ComboBox LoanTypeComboBox;
        private Button button1;
    }
}
