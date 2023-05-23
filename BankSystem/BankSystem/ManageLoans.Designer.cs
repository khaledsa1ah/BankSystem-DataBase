namespace BankSystem
{
    partial class ManageLoans
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
            LoanDataGridView = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)LoanDataGridView).BeginInit();
            SuspendLayout();
            // 
            // LoanDataGridView
            // 
            LoanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoanDataGridView.GridColor = SystemColors.MenuHighlight;
            LoanDataGridView.Location = new Point(350, 104);
            LoanDataGridView.Name = "LoanDataGridView";
            LoanDataGridView.RowHeadersWidth = 51;
            LoanDataGridView.RowTemplate.Height = 29;
            LoanDataGridView.Size = new Size(404, 229);
            LoanDataGridView.TabIndex = 0;
            LoanDataGridView.CellClick += LoanDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 51);
            label1.Name = "label1";
            label1.Size = new Size(239, 41);
            label1.TabIndex = 1;
            label1.Text = "Proposed Loans";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(165, 124);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 7;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(165, 220);
            button2.Name = "button2";
            button2.Size = new Size(134, 51);
            button2.TabIndex = 8;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ManageLoans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(LoanDataGridView);
            Name = "ManageLoans";
            Text = "ManageLoans";
            ((System.ComponentModel.ISupportInitialize)LoanDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LoanDataGridView;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}