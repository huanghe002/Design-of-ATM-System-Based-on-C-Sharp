namespace 银行系统
{
    partial class BankDeposit
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
            Input = new TextBox();
            DeptBack = new Label();
            DeptOK = new Label();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(295, 226);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 0;
            label1.Text = "输入存钱金额";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Input
            // 
            Input.ImeMode = ImeMode.Disable;
            Input.Location = new Point(463, 233);
            Input.Name = "Input";
            Input.Size = new Size(150, 30);
            Input.TabIndex = 1;
            Input.KeyPress += Input_KeyPress;
            // 
            // DeptBack
            // 
            DeptBack.BackColor = Color.FromArgb(192, 255, 255);
            DeptBack.Location = new Point(91, 392);
            DeptBack.Name = "DeptBack";
            DeptBack.Size = new Size(120, 61);
            DeptBack.TabIndex = 2;
            DeptBack.Text = "返回";
            DeptBack.TextAlign = ContentAlignment.MiddleCenter;
            DeptBack.Click += DeptBack_Click;
            // 
            // DeptOK
            // 
            DeptOK.BackColor = Color.FromArgb(192, 255, 255);
            DeptOK.Location = new Point(782, 392);
            DeptOK.Name = "DeptOK";
            DeptOK.Size = new Size(128, 61);
            DeptOK.TabIndex = 3;
            DeptOK.Text = "确定";
            DeptOK.TextAlign = ContentAlignment.MiddleCenter;
            DeptOK.Click += DeptOK_Click;
            // 
            // label4
            // 
            label4.Location = new Point(346, 105);
            label4.Name = "label4";
            label4.Size = new Size(267, 36);
            label4.TabIndex = 4;
            label4.Text = "请您将钞币整理齐后放入取款机";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(619, 227);
            label2.Name = "label2";
            label2.Size = new Size(44, 36);
            label2.TabIndex = 5;
            label2.Text = "元";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BankDeposit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(DeptOK);
            Controls.Add(DeptBack);
            Controls.Add(Input);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "BankDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankDeposit";
            Load += BankDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Input;
        private Label DeptBack;
        private Label DeptOK;
        private Label label4;
        private Label label2;
    }
}