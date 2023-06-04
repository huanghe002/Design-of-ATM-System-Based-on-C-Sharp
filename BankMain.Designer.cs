namespace 银行系统
{
    partial class BankMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMain));
            MainWithdraw = new Button();
            MainQuery = new Button();
            MainTranster = new Button();
            MainChangePassword = new Button();
            MainQuit = new Button();
            label1 = new Label();
            MainBack = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // MainWithdraw
            // 
            MainWithdraw.BackColor = Color.FromArgb(192, 255, 255);
            MainWithdraw.Location = new Point(73, 121);
            MainWithdraw.Name = "MainWithdraw";
            MainWithdraw.Size = new Size(203, 56);
            MainWithdraw.TabIndex = 2;
            MainWithdraw.Text = "取款（Withdraw）";
            MainWithdraw.UseVisualStyleBackColor = false;
            MainWithdraw.Click += button1_Click;
            // 
            // MainQuery
            // 
            MainQuery.BackColor = Color.FromArgb(192, 255, 255);
            MainQuery.Location = new Point(73, 320);
            MainQuery.Name = "MainQuery";
            MainQuery.Size = new Size(160, 53);
            MainQuery.TabIndex = 3;
            MainQuery.Text = "查询（Query）";
            MainQuery.UseVisualStyleBackColor = false;
            MainQuery.Click += button2_Click;
            // 
            // MainTranster
            // 
            MainTranster.BackColor = Color.FromArgb(192, 255, 255);
            MainTranster.Location = new Point(709, 121);
            MainTranster.Name = "MainTranster";
            MainTranster.Size = new Size(208, 56);
            MainTranster.TabIndex = 5;
            MainTranster.Text = "（Transter） 转 账";
            MainTranster.UseVisualStyleBackColor = false;
            MainTranster.Click += button4_Click;
            // 
            // MainChangePassword
            // 
            MainChangePassword.BackColor = Color.FromArgb(192, 255, 255);
            MainChangePassword.Location = new Point(658, 250);
            MainChangePassword.Name = "MainChangePassword";
            MainChangePassword.Size = new Size(259, 60);
            MainChangePassword.TabIndex = 6;
            MainChangePassword.Text = "（ChangePassord）更改密码";
            MainChangePassword.UseVisualStyleBackColor = false;
            MainChangePassword.Click += button5_Click;
            // 
            // MainQuit
            // 
            MainQuit.BackColor = Color.FromArgb(192, 255, 255);
            MainQuit.Location = new Point(778, 386);
            MainQuit.Name = "MainQuit";
            MainQuit.Size = new Size(139, 53);
            MainQuit.TabIndex = 7;
            MainQuit.Text = "（Quit）退 卡";
            MainQuit.UseVisualStyleBackColor = false;
            MainQuit.Click += button6_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(342, 65);
            label1.TabIndex = 8;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainBack
            // 
            MainBack.BackColor = Color.FromArgb(192, 255, 255);
            MainBack.Location = new Point(73, 432);
            MainBack.Name = "MainBack";
            MainBack.Size = new Size(139, 53);
            MainBack.TabIndex = 9;
            MainBack.Text = "返回（Back）";
            MainBack.UseVisualStyleBackColor = false;
            MainBack.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(73, 219);
            button1.Name = "button1";
            button1.Size = new Size(139, 55);
            button1.TabIndex = 11;
            button1.Text = "存款(Deposit)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BankMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(button1);
            Controls.Add(MainBack);
            Controls.Add(label1);
            Controls.Add(MainQuit);
            Controls.Add(MainChangePassword);
            Controls.Add(MainTranster);
            Controls.Add(MainQuery);
            Controls.Add(MainWithdraw);
            Name = "BankMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += BankMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MainWithdraw;
        private Button MainQuery;
        private Button MainTranster;
        private Button MainChangePassword;
        private Button MainQuit;
        private Label label1;
        private Button MainBack;
        private Button button1;
    }
}