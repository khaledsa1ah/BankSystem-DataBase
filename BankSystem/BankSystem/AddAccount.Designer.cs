namespace BankSystem
{
    partial class AddAccount
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
            BalanceBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            TypeBox = new ComboBox();
            SuspendLayout();
            // 
            // BalanceBox
            // 
            BalanceBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BalanceBox.Location = new Point(392, 307);
            BalanceBox.Name = "BalanceBox";
            BalanceBox.Size = new Size(344, 36);
            BalanceBox.TabIndex = 0;
            BalanceBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(392, 279);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Balance";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(392, 372);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 3;
            label2.Text = "Type";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(486, 195);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 4;
            label3.Text = "Add Account";
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(486, 493);
            button4.Name = "button4";
            button4.Size = new Size(141, 41);
            button4.TabIndex = 7;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TypeBox
            // 
            TypeBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TypeBox.FormattingEnabled = true;
            TypeBox.Items.AddRange(new object[] { "Checking", "Savings", "Business" });
            TypeBox.Location = new Point(392, 400);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(344, 38);
            TypeBox.TabIndex = 8;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TypeBox);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BalanceBox);
            Name = "AddAccount";
            Size = new Size(800, 800);
            Load += AddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BalanceBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private ComboBox TypeBox;
    }
}
