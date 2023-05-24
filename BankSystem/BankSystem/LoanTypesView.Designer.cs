namespace BankSystem
{
    partial class LoanTypesView
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
            LoanTypesDataGrid = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)LoanTypesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // LoanTypesDataGrid
            // 
            LoanTypesDataGrid.AllowUserToResizeColumns = false;
            LoanTypesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            LoanTypesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            LoanTypesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoanTypesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoanTypesDataGrid.BackgroundColor = Color.AliceBlue;
            LoanTypesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            LoanTypesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LoanTypesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LoanTypesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            LoanTypesDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            LoanTypesDataGrid.EnableHeadersVisualStyles = false;
            LoanTypesDataGrid.GridColor = Color.AliceBlue;
            LoanTypesDataGrid.Location = new Point(292, 249);
            LoanTypesDataGrid.Name = "LoanTypesDataGrid";
            LoanTypesDataGrid.RowHeadersVisible = false;
            LoanTypesDataGrid.RowTemplate.Height = 25;
            LoanTypesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoanTypesDataGrid.Size = new Size(452, 280);
            LoanTypesDataGrid.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(443, 583);
            button1.Name = "button1";
            button1.Size = new Size(160, 39);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 168);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 4;
            label1.Text = "Loan Types";
            // 
            // LoanTypesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoanTypesDataGrid);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoanTypesView";
            Size = new Size(800, 800);
            Load += LoanTypesView_Load;
            ((System.ComponentModel.ISupportInitialize)LoanTypesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LoanTypesDataGrid;
        private Button button1;
        private Label label1;
    }
}
