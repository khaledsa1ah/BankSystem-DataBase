namespace BankSystem
{
    partial class ViewAccounts
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
            UserAccountsDataGrid = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)UserAccountsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // UserAccountsDataGrid
            // 
            UserAccountsDataGrid.AllowUserToResizeColumns = false;
            UserAccountsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            UserAccountsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserAccountsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserAccountsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserAccountsDataGrid.BackgroundColor = Color.AliceBlue;
            UserAccountsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            UserAccountsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserAccountsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserAccountsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserAccountsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            UserAccountsDataGrid.EnableHeadersVisualStyles = false;
            UserAccountsDataGrid.GridColor = Color.AliceBlue;
            UserAccountsDataGrid.Location = new Point(294, 235);
            UserAccountsDataGrid.Name = "UserAccountsDataGrid";
            UserAccountsDataGrid.RowHeadersVisible = false;
            UserAccountsDataGrid.RowTemplate.Height = 25;
            UserAccountsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserAccountsDataGrid.Size = new Size(452, 280);
            UserAccountsDataGrid.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(351, 565);
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
            label1.Location = new Point(461, 159);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 4;
            label1.Text = "User Accounts";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(539, 565);
            button2.Name = "button2";
            button2.Size = new Size(160, 39);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ViewAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(UserAccountsDataGrid);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ViewAccounts";
            Size = new Size(800, 800);
            Load += ViewAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)UserAccountsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserAccountsDataGrid;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}
