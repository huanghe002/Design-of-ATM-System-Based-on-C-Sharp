namespace 银行系统
{
    partial class ZZZadd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btOk = new Button();
            btCancel = new Button();
            textAccount = new TextBox();
            textPin = new TextBox();
            textAvailablebalance = new TextBox();
            textTotalbalance = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(193, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 36);
            label1.TabIndex = 1;
            label1.Text = "用户账户";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(193, 184);
            label2.Name = "label2";
            label2.Size = new Size(94, 36);
            label2.TabIndex = 2;
            label2.Text = "用户密码";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Location = new Point(193, 251);
            label3.Name = "label3";
            label3.Size = new Size(94, 36);
            label3.TabIndex = 3;
            label3.Text = "可用余额";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Location = new Point(193, 313);
            label4.Name = "label4";
            label4.Size = new Size(94, 36);
            label4.TabIndex = 4;
            label4.Text = "总余额";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btOk
            // 
            btOk.BackColor = Color.FromArgb(192, 255, 255);
            btOk.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btOk.Location = new Point(109, 423);
            btOk.Name = "btOk";
            btOk.Size = new Size(146, 61);
            btOk.TabIndex = 9;
            btOk.Text = "添加";
            btOk.UseVisualStyleBackColor = false;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.FromArgb(192, 255, 255);
            btCancel.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.Location = new Point(481, 423);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(142, 61);
            btCancel.TabIndex = 10;
            btCancel.Text = "取消";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // textAccount
            // 
            textAccount.Location = new Point(335, 119);
            textAccount.Name = "textAccount";
            textAccount.Size = new Size(150, 30);
            textAccount.TabIndex = 11;
            textAccount.TextChanged += textBox1_TextChanged;
            textAccount.KeyPress += textBox1_KeyPress;
            // 
            // textPin
            // 
            textPin.Location = new Point(335, 187);
            textPin.Name = "textPin";
            textPin.Size = new Size(150, 30);
            textPin.TabIndex = 12;
            textPin.KeyPress += textBox2_KeyPress;
            // 
            // textAvailablebalance
            // 
            textAvailablebalance.Location = new Point(335, 254);
            textAvailablebalance.Name = "textAvailablebalance";
            textAvailablebalance.Size = new Size(150, 30);
            textAvailablebalance.TabIndex = 13;
            textAvailablebalance.KeyPress += textBox3_KeyPress;
            // 
            // textTotalbalance
            // 
            textTotalbalance.Location = new Point(335, 316);
            textTotalbalance.Name = "textTotalbalance";
            textTotalbalance.Size = new Size(150, 30);
            textTotalbalance.TabIndex = 14;
            textTotalbalance.KeyPress += textBox4_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(193, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 16;
            button1.Text = "序号";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(335, 71);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 17;
            textBox5.Text = "自动";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // ZZZadd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 569);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textTotalbalance);
            Controls.Add(textAvailablebalance);
            Controls.Add(textPin);
            Controls.Add(textAccount);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ZZZadd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZZZadd";
            Load += ZZZadd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btOk;
        private Button btCancel;
        private TextBox textAccount;
        private TextBox textPin;
        private TextBox textAvailablebalance;
        private TextBox textTotalbalance;
        private Button button1;
        private TextBox textBox5;
    }
}