namespace BankSystem
{
    partial class BranchData
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
            button1 = new Button();
            label2 = new Label();
            BranchDataGrid = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)BranchDataGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(360, 487);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 10;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(435, 185);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 9;
            label2.Text = "Branches Data";
            label2.Click += label2_Click;
            // 
            // BranchDataGrid
            // 
            BranchDataGrid.AllowUserToResizeColumns = false;
            BranchDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            BranchDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BranchDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BranchDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BranchDataGrid.BackgroundColor = Color.AliceBlue;
            BranchDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            BranchDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BranchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BranchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BranchDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            BranchDataGrid.EnableHeadersVisualStyles = false;
            BranchDataGrid.GridColor = SystemColors.ButtonHighlight;
            BranchDataGrid.Location = new Point(284, 234);
            BranchDataGrid.Name = "BranchDataGrid";
            BranchDataGrid.RowHeadersVisible = false;
            BranchDataGrid.RowTemplate.Height = 25;
            BranchDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BranchDataGrid.Size = new Size(469, 217);
            BranchDataGrid.TabIndex = 8;
            BranchDataGrid.CellContentClick += BranchDataGrid_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(521, 487);
            button2.Name = "button2";
            button2.Size = new Size(141, 41);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BranchData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(BranchDataGrid);
            Name = "BranchData";
            Size = new Size(800, 800);
            Load += BranchData_Load;
            ((System.ComponentModel.ISupportInitialize)BranchDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private DataGridView BranchDataGrid;
        private Button button2;
    }
}
