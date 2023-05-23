namespace BankSystem
{
    partial class BankData
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
            BankDataGrid = new DataGridView();
            BranchDataGrid = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BankDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BranchDataGrid).BeginInit();
            SuspendLayout();
            // 
            // BankDataGrid
            // 
            BankDataGrid.BackgroundColor = SystemColors.Highlight;
            BankDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankDataGrid.GridColor = SystemColors.ActiveCaption;
            BankDataGrid.Location = new Point(43, 82);
            BankDataGrid.Name = "BankDataGrid";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BankDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BankDataGrid.RowTemplate.Height = 25;
            BankDataGrid.Size = new Size(469, 217);
            BankDataGrid.TabIndex = 0;
            BankDataGrid.CellContentClick += BankDataGrid_CellContentClick;
            // 
            // BranchDataGrid
            // 
            BranchDataGrid.BackgroundColor = SystemColors.Highlight;
            BranchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchDataGrid.GridColor = SystemColors.ButtonHighlight;
            BranchDataGrid.Location = new Point(43, 379);
            BranchDataGrid.Name = "BranchDataGrid";
            BranchDataGrid.RowTemplate.Height = 25;
            BranchDataGrid.Size = new Size(469, 217);
            BranchDataGrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(141, 344);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 6;
            label2.Text = "Branches Data";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(154, 645);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 7;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 5;
            label1.Text = "Banks Data";
            // 
            // BankData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BranchDataGrid);
            Controls.Add(BankDataGrid);
            Name = "BankData";
            Size = new Size(800, 800);
            ((System.ComponentModel.ISupportInitialize)BankDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BranchDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BankDataGrid;
        private DataGridView BranchDataGrid;
        private Label label2;
        private Button button1;
        private Label label1;
    }
}
