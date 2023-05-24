namespace BankSystem
{
    partial class LoanData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            TakenLoansDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TakenLoansDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(488, 171);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 1;
            label1.Text = "Loans";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(439, 587);
            button1.Name = "button1";
            button1.Size = new Size(160, 39);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TakenLoansDataGrid
            // 
            TakenLoansDataGrid.AllowUserToResizeColumns = false;
            TakenLoansDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            TakenLoansDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TakenLoansDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TakenLoansDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TakenLoansDataGrid.BackgroundColor = Color.AliceBlue;
            TakenLoansDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TakenLoansDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TakenLoansDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TakenLoansDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TakenLoansDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            TakenLoansDataGrid.EnableHeadersVisualStyles = false;
            TakenLoansDataGrid.GridColor = Color.AliceBlue;
            TakenLoansDataGrid.Location = new Point(288, 253);
            TakenLoansDataGrid.Name = "TakenLoansDataGrid";
            TakenLoansDataGrid.RowHeadersVisible = false;
            TakenLoansDataGrid.RowTemplate.Height = 25;
            TakenLoansDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TakenLoansDataGrid.Size = new Size(452, 280);
            TakenLoansDataGrid.TabIndex = 3;
            // 
            // LoanData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TakenLoansDataGrid);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoanData";
            Size = new Size(800, 800);
            Load += LoanData_Load;
            ((System.ComponentModel.ISupportInitialize)TakenLoansDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private DataGridView TakenLoansDataGrid;
    }
}
