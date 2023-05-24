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
            LoanDataGridView.Location = new Point(306, 78);
            LoanDataGridView.Margin = new Padding(3, 2, 3, 2);
            LoanDataGridView.Name = "LoanDataGridView";
            LoanDataGridView.RowHeadersWidth = 51;
            LoanDataGridView.RowTemplate.Height = 29;
            LoanDataGridView.Size = new Size(354, 172);
            LoanDataGridView.TabIndex = 0;
            LoanDataGridView.CellClick += LoanDataGridView_CellClick;
            LoanDataGridView.CellContentClick += LoanDataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(374, 38);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 1;
            label1.Text = "Proposed Loans";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(144, 93);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 7;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(144, 165);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(117, 38);
            button2.TabIndex = 8;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ManageLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(LoanDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageLoans";
            Text = "ManageLoans";
            Load += ManageLoans_Load;
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