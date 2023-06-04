using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 银行系统
{
    public partial class bankTranster : Form
    {
        private BankMain bankMain;
        private Screen screen;
        private BankDatabase bankDatabase;
        private int InputaccountNumber;
        private Keypad Keypad;
        public void accountNumber(int accountNumber)     //得到用户账户
        { InputaccountNumber = accountNumber; }
        public bankTranster()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void TsterBack_Click(object sender, EventArgs e)
        {
            bankMain.accountNumber(InputaccountNumber);          //把账户账户传回ATM主页去，方便继续操作
            this.Close();
            bankMain.Show();
        }

        private void Transter_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';     //密码隐秘
            bankMain = new BankMain();     //功能实例化
            screen = new Screen();
            bankDatabase = new BankDatabase();
            Keypad = new Keypad();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TsterOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))   //判别是否有信息未填写
                screen.DisplayMessageLine("操作失败", "若继续转账请将信息填完整");
            else
            {
                if (Keypad.GetInput(textBox1.Text) != -1 && Keypad.GetInput(textBox2.Text) != -1 && Keypad.GetInput(textBox3.Text) != -1 && Keypad.GetInput(textBox4.Text) != -1)   //检测是否为正整数
                {
                    if (bankDatabase.AuthenticateUser(InputaccountNumber, Keypad.GetInput(textBox4.Text)) == true)      //检测交易密码是否正确
                    {
                        if (textBox1.Text == textBox2.Text)
                        {
                            if (Keypad.GetInput(textBox1.Text) != InputaccountNumber)
                            {
                                if (bankDatabase.GetAccount(Keypad.GetInput(textBox1.Text)) != null)       //检查收款用户是否存在
                                {
                                    double availableBalance = bankDatabase.GetAvailableBalance(InputaccountNumber);
                                    int transterBalance = Keypad.GetInput(textBox3.Text);
                                    if (transterBalance <= availableBalance)                       //判断账户的余额是否够转账
                                    {
                                        bankDatabase.Debit(InputaccountNumber, transterBalance);  //该账户转出钱
                                        bankDatabase.Credit(Keypad.GetInput(textBox1.Text), transterBalance);    //接收账户转入钱
                                        screen.DisplayMessage("转账成功！");
                                        this.Close();
                                        bankMain.Show();
                                        bankMain.accountNumber(InputaccountNumber);          //把账户账户传回ATM主页去，方便继续操作
                                    }
                                    else
                                    {
                                        screen.DisplayMessageLine("转账失败", "该账户余额不足！若需继续转账请继续操作");
                                        textBox3.Text = ""; textBox4.Text = "";    //删除转账余额框和密码框
                                    }
                                }
                                else
                                {
                                    screen.DisplayMessageLine("转账失败", "用户不存在");    //对方用户不存在
                                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";//请空输入
                                }
                            }
                            else
                            {
                                screen.DisplayMessageLine("转账失败", "对方账户为自己账户");    //对方账户为自己账户时
                                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";//请空输入
                            }
                        }
                        else
                        {
                            screen.DisplayMessageLine("转账失败", "对方账户输入不一致");
                            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";//请空输入
                        }
                    }
                    else
                    {
                        screen.DisplayMessageLine("转账失败", "交易密码错误");
                        textBox4.Text = "";      //密码清空
                    }
                }
                else
                {
                    screen.DisplayMessageLine("转账失败", "请输入正整数");
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";//请空输入
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
