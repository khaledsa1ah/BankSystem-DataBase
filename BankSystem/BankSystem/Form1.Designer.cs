namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            homePage1 = new HomePage();
            SuspendLayout();
            // 
            // entityCommand1
            // 
            entityCommand1.CommandTimeout = 0;
            entityCommand1.CommandTree = null;
            entityCommand1.Connection = null;
            entityCommand1.EnablePlanCaching = true;
            entityCommand1.Transaction = null;
            // 
            // homePage1
            // 
            homePage1.BackColor = SystemColors.Window;
            homePage1.Location = new Point(-7, -31);
            homePage1.Margin = new Padding(0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(800, 800);
            homePage1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(784, 761);
            Controls.Add(homePage1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Register register1;
        private HomePage homePage1;
    }
}