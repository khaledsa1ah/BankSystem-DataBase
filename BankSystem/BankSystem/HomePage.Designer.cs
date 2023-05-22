namespace BankSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label2 = new Label();
            label1 = new Label();
            SNNBox = new TextBox();
            PasswordBox = new TextBox();
            RegisterBtn = new Button();
            LoginBtn = new Button();
            groupBox1 = new GroupBox();
            ErrorLabel = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            register1 = new Register();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 161);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 76);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 13;
            label1.Text = "SNN";
            // 
            // SNNBox
            // 
            SNNBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SNNBox.ForeColor = SystemColors.WindowText;
            SNNBox.Location = new Point(22, 100);
            SNNBox.Name = "SNNBox";
            SNNBox.Size = new Size(269, 35);
            SNNBox.TabIndex = 12;
            SNNBox.TextChanged += textBox2_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = SystemColors.WindowText;
            PasswordBox.Location = new Point(22, 185);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(269, 35);
            PasswordBox.TabIndex = 11;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.Location = new Point(22, 352);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(269, 52);
            RegisterBtn.TabIndex = 10;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Tomato;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(22, 273);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(269, 52);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(ErrorLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RegisterBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LoginBtn);
            groupBox1.Controls.Add(SNNBox);
            groupBox1.Controls.Add(PasswordBox);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Tomato;
            groupBox1.Location = new Point(49, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 454);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(22, 239);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 17);
            ErrorLabel.TabIndex = 18;
            ErrorLabel.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 100);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(551, 45);
            label3.TabIndex = 16;
            label3.Text = "Welcome to our Bank Application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ImageLocation = "C:\\Users\\over-\\source\\repos\\BankSystem\\BankSystem\\E-Wallet-pana.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(427, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 328);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // register1
            // 
            register1.BackColor = Color.White;
            register1.Location = new Point(0, 0);
            register1.Name = "register1";
            register1.Size = new Size(800, 800);
            register1.TabIndex = 18;
            register1.Load += register1_Load;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(register1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "HomePage";
            Size = new Size(800, 800);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox SNNBox;
        private TextBox PasswordBox;
        private Button RegisterBtn;
        private Button LoginBtn;
        private GroupBox groupBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label ErrorLabel;
        private Register register1;
    }
}
