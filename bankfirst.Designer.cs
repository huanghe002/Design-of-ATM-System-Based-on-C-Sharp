namespace 银行系统
{
    partial class bankfirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankfirst));
            firstOK = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            InputPin = new TextBox();
            lblMessage = new Label();
            btnShow = new LinkLabel();
            SuspendLayout();
            // 
            // firstOK
            // 
            firstOK.BackColor = Color.FromArgb(192, 255, 255);
            firstOK.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            firstOK.Location = new Point(408, 332);
            firstOK.Name = "firstOK";
            firstOK.Size = new Size(145, 79);
            firstOK.TabIndex = 0;
            firstOK.Text = "确定";
            firstOK.UseVisualStyleBackColor = false;
            firstOK.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(303, 171);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 1;
            label1.Text = "账号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(303, 242);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 2;
            label2.Text = "密码";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(320, 45);
            label3.Name = "label3";
            label3.Size = new Size(336, 58);
            label3.TabIndex = 3;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.Disable;
            textBox1.Location = new Point(432, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // InputPin
            // 
            InputPin.ImeMode = ImeMode.Disable;
            InputPin.Location = new Point(432, 242);
            InputPin.Name = "InputPin";
            InputPin.Size = new Size(150, 30);
            InputPin.TabIndex = 5;
            InputPin.KeyPress += InputPin_KeyPress;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(444, 288);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 24);
            lblMessage.TabIndex = 6;
            lblMessage.Visible = false;
            // 
            // btnShow
            // 
            btnShow.AutoSize = true;
            btnShow.Location = new Point(588, 245);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(82, 24);
            btnShow.TabIndex = 7;
            btnShow.TabStop = true;
            btnShow.Text = "显示密码";
            btnShow.LinkClicked += linkLabel1_LinkClicked;
            // 
            // bankfirst
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 534);
            Controls.Add(btnShow);
            Controls.Add(lblMessage);
            Controls.Add(InputPin);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstOK);
            Name = "bankfirst";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bankfirst";
            Load += bankfirst_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button firstOK;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox InputPin;
        private Label lblMessage;
        private LinkLabel btnShow;
    }
}