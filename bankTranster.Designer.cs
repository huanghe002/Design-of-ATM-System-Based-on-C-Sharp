namespace 银行系统
{
    partial class bankTranster
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            TsterBack = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            TsterOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(270, 107);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 0;
            label1.Text = "请输入对方账号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(270, 175);
            label2.Name = "label2";
            label2.Size = new Size(141, 41);
            label2.TabIndex = 1;
            label2.Text = "再次输入账号";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.Disable;
            textBox1.Location = new Point(467, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.ImeMode = ImeMode.Disable;
            textBox2.Location = new Point(467, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.ImeMode = ImeMode.Disable;
            textBox3.Location = new Point(467, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Location = new Point(270, 242);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 5;
            label3.Text = "输入转账金额";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // TsterBack
            // 
            TsterBack.BackColor = Color.FromArgb(192, 255, 255);
            TsterBack.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TsterBack.Location = new Point(45, 417);
            TsterBack.Name = "TsterBack";
            TsterBack.Size = new Size(139, 67);
            TsterBack.TabIndex = 11;
            TsterBack.Text = "返回（Back）";
            TsterBack.UseVisualStyleBackColor = false;
            TsterBack.Click += TsterBack_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Location = new Point(270, 310);
            label4.Name = "label4";
            label4.Size = new Size(141, 41);
            label4.TabIndex = 12;
            label4.Text = "请输入交易密码";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.ImeMode = ImeMode.Disable;
            textBox4.Location = new Point(467, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 13;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // TsterOK
            // 
            TsterOK.BackColor = Color.FromArgb(192, 255, 255);
            TsterOK.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            TsterOK.Location = new Point(734, 412);
            TsterOK.Name = "TsterOK";
            TsterOK.Size = new Size(146, 67);
            TsterOK.TabIndex = 14;
            TsterOK.Text = "确认";
            TsterOK.UseVisualStyleBackColor = false;
            TsterOK.Click += TsterOK_Click;
            // 
            // bankTranster
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(TsterOK);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(TsterBack);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bankTranster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transter";
            Load += Transter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button TsterBack;
        private Label label4;
        private TextBox textBox4;
        private Button TsterOK;
    }
}