using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace 银行系统
{
    public partial class bankfirst : Form
    {
        private BankMain bankmain;          //功能调进来
        private Screen screen;
        private B_ATM aTM;
        private Keypad keypad;
        private BankDatabase bankdatabase;
        private Accesssdata accesssdata;
        private ZZZManage zZManage;

        public bankfirst()
        {

            InitializeComponent();
        }

        private void bankfirst_Load(object sender, EventArgs e)
        {
            InputPin.PasswordChar = '*';     //密码隐秘
            bankmain = new BankMain();      //将功能实例化
            screen = new Screen();
            keypad = new Keypad();
            aTM = new B_ATM();
            bankdatabase = new BankDatabase();
            accesssdata = new Accesssdata();
            zZManage = new ZZZManage();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int i, a = 0;
            // 获取用户输入的卡号和密码
            string accountNumberText = textBox1.Text;
            string pinText = InputPin.Text;
            if (string.IsNullOrEmpty(accountNumberText) && string.IsNullOrEmpty(pinText))     //判断账户和密码输入是否全空
            {
                screen.DisplayMessage("请输入账号和密码！");
                return;
            }
            else if (string.IsNullOrEmpty(accountNumberText)) { screen.DisplayMessage("请输入账号！"); return; }  //判断账户是否为空
            else if (string.IsNullOrEmpty(pinText)) { screen.DisplayMessage("请输入密码！"); return; }      //判断密码是否为空
            else
            {
                if (keypad.GetInput(textBox1.Text) != -1 && keypad.GetInput(InputPin.Text) != -1)         //判断是否为整型
                {
                    if (aTM.AuthenticateUser(keypad.GetInput(textBox1.Text), keypad.GetInput(InputPin.Text)) == int.Parse(textBox1.Text))  //验证账户是否账户密码都正确
                    {
                        bankmain.accountNumber(keypad.GetInput(textBox1.Text));
                        this.Hide();
                        bankmain.Show();
                        aTM.DisplayMainMenu();

                    }
                    else if (accesssdata.AuthenticateAdmini(keypad.GetInput(textBox1.Text), keypad.GetInput(InputPin.Text)))   //管理者验证
                    {
                        this.Hide();
                        zZManage.Show();
                        screen.DisplayMessage("欢迎进入管理者后台");
                    }
                    else           //若验证错误,清空输入
                    {
                        screen.DisplayMessageLine("账号或密码错误", "请再次输入");
                        textBox1.Text = "";
                        InputPin.Text = "";
                        return;
                    }
                }
                else
                {
                    textBox1.Text = "";
                    InputPin.Text = "";
                    return;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InputPin.PasswordChar == '*')
            {
                InputPin.PasswordChar = '\0';
                btnShow.Text = "隐藏密码";
            }

            else
            {
                InputPin.PasswordChar = '*';
                btnShow.Text = "显示密码";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void InputPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}













