namespace 银行系统
{
    partial class bankTransaction
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
            Tran100 = new Button();
            Tran200 = new Button();
            Tran500 = new Button();
            Tran1000 = new Button();
            Tran2000 = new Button();
            TranBack = new Button();
            TranOK = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Tran100
            // 
            Tran100.BackColor = Color.FromArgb(192, 255, 255);
            Tran100.Location = new Point(39, 83);
            Tran100.Name = "Tran100";
            Tran100.Size = new Size(153, 58);
            Tran100.TabIndex = 0;
            Tran100.Text = "1-----100元";
            Tran100.UseVisualStyleBackColor = false;
            // 
            // Tran200
            // 
            Tran200.BackColor = Color.FromArgb(192, 255, 255);
            Tran200.Location = new Point(39, 182);
            Tran200.Name = "Tran200";
            Tran200.Size = new Size(153, 58);
            Tran200.TabIndex = 1;
            Tran200.Text = "2----200元";
            Tran200.UseVisualStyleBackColor = false;
            // 
            // Tran500
            // 
            Tran500.BackColor = Color.FromArgb(192, 255, 255);
            Tran500.Location = new Point(39, 285);
            Tran500.Name = "Tran500";
            Tran500.Size = new Size(153, 58);
            Tran500.TabIndex = 2;
            Tran500.Text = "3----500元";
            Tran500.UseVisualStyleBackColor = false;
            // 
            // Tran1000
            // 
            Tran1000.BackColor = Color.FromArgb(192, 255, 255);
            Tran1000.Location = new Point(754, 67);
            Tran1000.Name = "Tran1000";
            Tran1000.Size = new Size(153, 58);
            Tran1000.TabIndex = 3;
            Tran1000.Text = "4----1000元";
            Tran1000.UseVisualStyleBackColor = false;
            // 
            // Tran2000
            // 
            Tran2000.BackColor = Color.FromArgb(192, 255, 255);
            Tran2000.Location = new Point(754, 182);
            Tran2000.Name = "Tran2000";
            Tran2000.Size = new Size(153, 58);
            Tran2000.TabIndex = 4;
            Tran2000.Text = "5----2000元";
            Tran2000.UseVisualStyleBackColor = false;
            Tran2000.Click += Tran2000_Click;
            // 
            // TranBack
            // 
            TranBack.BackColor = Color.FromArgb(192, 255, 255);
            TranBack.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TranBack.Location = new Point(39, 412);
            TranBack.Name = "TranBack";
            TranBack.Size = new Size(139, 58);
            TranBack.TabIndex = 6;
            TranBack.Text = "返回（Back）";
            TranBack.UseVisualStyleBackColor = false;
            TranBack.Click += button7_Click;
            // 
            // TranOK
            // 
            TranOK.BackColor = Color.FromArgb(192, 255, 255);
            TranOK.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TranOK.Location = new Point(754, 421);
            TranOK.Name = "TranOK";
            TranOK.Size = new Size(153, 58);
            TranOK.TabIndex = 8;
            TranOK.Text = "确定";
            TranOK.UseVisualStyleBackColor = false;
            TranOK.Click += button8_Click;
            // 
            // label1
            // 
            label1.Location = new Point(322, 285);
            label1.Name = "label1";
            label1.Size = new Size(380, 36);
            label1.TabIndex = 9;
            label1.Text = "请输入您想领取的金额，输入前面对应的标号即可即可";
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.Disable;
            textBox1.Location = new Point(404, 327);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(754, 297);
            label2.Name = "label2";
            label2.Size = new Size(153, 58);
            label2.TabIndex = 11;
            label2.Text = "6----取消交易";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bankTransaction
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TranOK);
            Controls.Add(TranBack);
            Controls.Add(Tran2000);
            Controls.Add(Tran1000);
            Controls.Add(Tran500);
            Controls.Add(Tran200);
            Controls.Add(Tran100);
            Name = "bankTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bankTransaction";
            Load += bankTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Tran100;
        private Button Tran200;
        private Button Tran500;
        private Button Tran1000;
        private Button Tran2000;
        private Button TranBack;
        private Button TranOK;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}