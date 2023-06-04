namespace 银行系统
{
    partial class ZZZManage
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            order = new DataGridViewTextBoxColumn();
            accountNumber = new DataGridViewTextBoxColumn();
            pin = new DataGridViewTextBoxColumn();
            availableBalance = new DataGridViewTextBoxColumn();
            totalBalance = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Tip = new LinkLabel();
            btupdate = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order, accountNumber, pin, availableBalance, totalBalance });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(723, 662);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // order
            // 
            order.DataPropertyName = "order";
            order.HeaderText = "序号";
            order.MinimumWidth = 8;
            order.Name = "order";
            order.Width = 80;
            // 
            // accountNumber
            // 
            accountNumber.DataPropertyName = "accountNumber";
            accountNumber.HeaderText = "用户账户";
            accountNumber.MinimumWidth = 8;
            accountNumber.Name = "accountNumber";
            accountNumber.Width = 150;
            // 
            // pin
            // 
            pin.DataPropertyName = "pin";
            pin.HeaderText = "密码";
            pin.MinimumWidth = 8;
            pin.Name = "pin";
            pin.Width = 150;
            // 
            // availableBalance
            // 
            availableBalance.DataPropertyName = "availableBalance";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            availableBalance.DefaultCellStyle = dataGridViewCellStyle1;
            availableBalance.HeaderText = "可用余额";
            availableBalance.MinimumWidth = 8;
            availableBalance.Name = "availableBalance";
            availableBalance.Width = 170;
            // 
            // totalBalance
            // 
            totalBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalBalance.DataPropertyName = "totalBalance";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            totalBalance.DefaultCellStyle = dataGridViewCellStyle2;
            totalBalance.HeaderText = "总余额";
            totalBalance.MinimumWidth = 8;
            totalBalance.Name = "totalBalance";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(791, 103);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 1;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(791, 189);
            button2.Name = "button2";
            button2.Size = new Size(125, 52);
            button2.TabIndex = 2;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(791, 280);
            button3.Name = "button3";
            button3.Size = new Size(125, 52);
            button3.TabIndex = 3;
            button3.Text = "修改";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(791, 533);
            button4.Name = "button4";
            button4.Size = new Size(141, 63);
            button4.TabIndex = 4;
            button4.Text = "退出";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Tip
            // 
            Tip.AutoSize = true;
            Tip.Location = new Point(866, 638);
            Tip.Name = "Tip";
            Tip.Size = new Size(82, 24);
            Tip.TabIndex = 5;
            Tip.TabStop = true;
            Tip.Text = "操作提示";
            Tip.LinkClicked += Tip_LinkClicked;
            // 
            // btupdate
            // 
            btupdate.BackColor = Color.FromArgb(192, 255, 255);
            btupdate.Location = new Point(791, 365);
            btupdate.Name = "btupdate";
            btupdate.Size = new Size(125, 50);
            btupdate.TabIndex = 6;
            btupdate.Text = "刷新数据";
            btupdate.UseVisualStyleBackColor = false;
            btupdate.Click += btupdate_Click;
            // 
            // ZZZManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(960, 664);
            Controls.Add(btupdate);
            Controls.Add(Tip);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ZZZManage";
            Text = "Manage";
            Load += ZZZManage_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private LinkLabel Tip;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn accountNumber;
        private DataGridViewTextBoxColumn pin;
        private DataGridViewTextBoxColumn availableBalance;
        private DataGridViewTextBoxColumn totalBalance;
        private Button btupdate;
    }
}