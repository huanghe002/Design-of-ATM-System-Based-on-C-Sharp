using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 银行系统
{
    public partial class ChangedPassord : Form
    {
        private BankDatabase bankDatabase;
        private Screen screen;
        private Keypad keypad;
        public BankMain bankMain;
        public int InputaccountNumber;
        public void accountNumber(int accountNumber)     //得到用户账号
        { InputaccountNumber = accountNumber; }
        public ChangedPassord()
        {
            InitializeComponent();
        }

        private void PassBack_Click(object sender, EventArgs e)
        {
            bankMain.accountNumber(InputaccountNumber);        //把账户账户传回去，方便继续操作
            this.Close();     //退出回到主界面，并关闭此界面
            bankMain.Show();
        }

        private void ChangedPassord_Load(object sender, EventArgs e)
        {
            screen = new Screen();       //功能实例化
            keypad = new Keypad();
            bankDatabase = new BankDatabase();
            bankMain = new BankMain();
        }

        private void PassOK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))   //判别是否有信息未填写
            {
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                screen.DisplayMessageLine("操作失败", "若继续转账请将信息填完整");
            }
            else
            {
                if (keypad.GetInput(textBox1.Text) != -1 && keypad.GetInput(textBox2.Text) != -1 && keypad.GetInput(textBox3.Text) != -1)    //判断是否为正整数
                {
                    if (bankDatabase.AuthenticateUser(InputaccountNumber, keypad.GetInput(textBox1.Text)))   // 校验当前密码是否正确
                    {
                        if (keypad.GetInput(textBox2.Text) != keypad.GetInput(textBox3.Text)) screen.DisplayMessageLine("修改失败", "新密码两次输入不一致");
                        else    // 修改密码
                        {
                            if (keypad.GetInput(textBox1.Text) != keypad.GetInput(textBox2.Text))
                            {
                                if (bankDatabase.Changepassword(InputaccountNumber, keypad.GetInput(textBox2.Text), keypad.GetInput(textBox1.Text)))
                                {
                                    bankMain.accountNumber(InputaccountNumber);        //把账户账户传回去，方便继续操作
                                    this.Close();           //修改成功后关闭此界面，回到主界面
                                    bankMain.Show();
                                    screen.DisplayMessage("修改成功");

                                }
                                else
                                {
                                    screen.DisplayMessage("修改失败");
                                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";  //清空输入
                                    return;
                                }
                            }
                            else
                            {
                                screen.DisplayMessage("修改失败,原密码与新密码一致\n若继续修改请重新输入 \n退出按返回键");
                                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";  //清空输入
                                return;
                            }
                        }
                    }
                    else
                    {
                        screen.DisplayMessage("当前密码错误，请重新输入");
                        textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";  //清空输入
                        return;
                    }
                }
                else
                {
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";   //清空输入
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
