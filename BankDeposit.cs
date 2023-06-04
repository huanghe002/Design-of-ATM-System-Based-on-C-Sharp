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
    public partial class BankDeposit : Form
    {
        private BankMain bankMain;
        public int InputaccountNumber;
        private Keypad keypad;
        private B_ATM aTM;
        public void accountNumber(int accountNumber)    //得到用户账号
        { InputaccountNumber = accountNumber; }
        public BankDeposit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeptBack_Click(object sender, EventArgs e)
        {
            bankMain.accountNumber(InputaccountNumber);       //把账户账户传回ATM主页去，方便继续操作
            this.Close();    //退出时关闭此界面，回到主界面
            bankMain.Show();
        }

        private void BankDeposit_Load(object sender, EventArgs e)
        {
            bankMain = new BankMain();     //功能实例化
            keypad = new Keypad();
            aTM = new B_ATM();
        }

        private void DeptOK_Click(object sender, EventArgs e)
        {
            bankMain.accountNumber(InputaccountNumber);    //把账户账户传回ATM主页去，方便继续操作
            if (string.IsNullOrEmpty(Input.Text))
            {
                Screen screen = new Screen();
                screen.DisplayMessage("请将钞币放入存钱口");
            }
            else
            {
                int a = keypad.GetInput(Input.Text);
                aTM.Run(InputaccountNumber, 2, a);       //执行存款
                Input.Text = "";     //清空存款金额
            }
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
