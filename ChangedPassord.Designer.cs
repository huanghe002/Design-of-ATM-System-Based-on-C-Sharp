namespace 银行系统
{
    partial class ChangedPassord
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            PassOK = new Button();
            PassBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(270, 113);
            label1.Name = "label1";
            label1.Size = new Size(139, 36);
            label1.TabIndex = 0;
            label1.Text = "原密码";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(270, 190);
            label2.Name = "label2";
            label2.Size = new Size(139, 36);
            label2.TabIndex = 1;
            label2.Text = "新密码";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Location = new Point(270, 261);
            label3.Name = "label3";
            label3.Size = new Size(139, 41);
            label3.TabIndex = 2;
            label3.Text = "再次输入新密码";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.Disable;
            textBox1.Location = new Point(452, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.ImeMode = ImeMode.Disable;
            textBox2.Location = new Point(452, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.ImeMode = ImeMode.Disable;
            textBox3.Location = new Point(452, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 5;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // PassOK
            // 
            PassOK.BackColor = Color.FromArgb(192, 255, 255);
            PassOK.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            PassOK.Location = new Point(723, 372);
            PassOK.Name = "PassOK";
            PassOK.Size = new Size(146, 67);
            PassOK.TabIndex = 6;
            PassOK.Text = "确认";
            PassOK.UseVisualStyleBackColor = false;
            PassOK.Click += PassOK_Click;
            // 
            // PassBack
            // 
            PassBack.BackColor = Color.FromArgb(192, 255, 255);
            PassBack.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PassBack.Location = new Point(46, 372);
            PassBack.Name = "PassBack";
            PassBack.Size = new Size(139, 67);
            PassBack.TabIndex = 10;
            PassBack.Text = "返回（Back）";
            PassBack.UseVisualStyleBackColor = false;
            PassBack.Click += PassBack_Click;
            // 
            // ChangedPassord
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(PassBack);
            Controls.Add(PassOK);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangedPassord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangedPassord";
            Load += ChangedPassord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button PassOK;
        private Button PassBack;
    }
}