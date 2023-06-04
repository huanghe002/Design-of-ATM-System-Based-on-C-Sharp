using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 银行系统
{

    public partial class bankTransaction : Form
    {
        private BankMain bankmain1;
        private Keypad keypad;
        private B_ATM aTM;
        private int InputaccountNumber;
        public void accountNumber(int accountNumber)
        { InputaccountNumber = accountNumber; }
        public bankTransaction()
        {

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bankTransaction_Load(object sender, EventArgs e)
        {
            bankmain1 = new BankMain();
            keypad = new Keypad();
            aTM = new B_ATM();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen screen = new Screen();
            int a = keypad.GetInput(textBox1.Text);        //获取用户取款选项
            aTM.Run(InputaccountNumber, 1, a);    //执行取款
            textBox1.Text = "";         //清空选项
            screen.DisplayMessage("继续取款请接着操作，取消交易按返回键");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bankmain1.accountNumber(InputaccountNumber);          //把账户账户传回ATM主页去，方便继续操作
            this.Close();       //关闭窗口回到界面
            bankmain1.Show();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Tran2000_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
