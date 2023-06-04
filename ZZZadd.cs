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
    public partial class ZZZadd : Form
    {
        private ZZZManage zZManage;
        private Keypad keypad;
        private Screen screen;
        private Accesssdata accesssdata;
        private BankDatabase bankDatabase;
        public ZZZadd()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //判断信息是否填写完整
            if (string.IsNullOrEmpty(textPin.Text) && string.IsNullOrEmpty(textAvailablebalance.Text) && string.IsNullOrEmpty(textTotalbalance.Text) && string.IsNullOrEmpty(textBox5.Text))
            {
                screen.DisplayMessageLine("添加失败", "请将信息填写完整后再按添加键");
            }
            else
            {
                int addacoountNumbert = keypad.GetInput(textAccount.Text);
                int addPin = keypad.GetInput(textPin.Text);
                double addavailableBalance = Convert.ToDouble(textAvailablebalance.Text);
                double addtotalBalance = Convert.ToDouble(textTotalbalance.Text);
                if (bankDatabase.GetAccount(addacoountNumbert) == null)         //判断账户是否存在
                {
                    if (addavailableBalance <= addtotalBalance)      //判断输入的可用余额是否小于或等于总余额
                    {
                        accesssdata.InsertAccount(addacoountNumbert, addPin, addavailableBalance, addtotalBalance);        //操纵数据库执行添加
                        textAccount.Text = ""; textPin.Text = ""; textAvailablebalance.Text = ""; textTotalbalance.Text = "";
                        this.Hide();

                    }
                    else
                    {
                        screen.DisplayMessageLine("添加失败", "可用余额大于总余额\n请重新输入可用余额和总余额");
                        textAvailablebalance.Text = ""; textTotalbalance.Text = "";
                    }
                }
                else
                {
                    screen.DisplayMessageLine("添加失败，账户已存在", "如若添加请重新填写信息\n退出按返回键");
                    textAccount.Text = ""; textPin.Text = ""; textAvailablebalance.Text = ""; textTotalbalance.Text = "";      //账户存在时清空输入
                }
            }
        }

        private void ZZZadd_Load(object sender, EventArgs e)
        {
            zZManage = new ZZZManage();       //将功能实例化
            keypad = new Keypad();
            screen = new Screen();
            accesssdata = new Accesssdata();
            bankDatabase = new BankDatabase();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            textAccount.Text = ""; textPin.Text = ""; textAvailablebalance.Text = ""; textTotalbalance.Text = "";
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，账户输入设定为仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)    //限制输入，密码输入设定为仅输入为数字和删除
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != (char)('.'))      //输入金额设定规则，限制输入其他字符串
            {
                screen.DisplayMessage("请输入正确的数字");
                e.Handled = true;
            }
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                screen.DisplayMessage("第一位不能为小数点");
                e.Handled = true;
            }
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                screen.DisplayMessage("小数点只能输入一次");
                e.Handled = true;
            }
            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0" && (e.KeyChar != 8))
            {
                screen.DisplayMessage("第一位是0，第二位必须是小数点");
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != (char)('.'))         //输入金额设定规则，限制输入其他字符串
            {
                screen.DisplayMessage("请输入正确的数字");
                e.Handled = true;
            }
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                screen.DisplayMessage("第一位不能为小数点");
                e.Handled = true;
            }
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                screen.DisplayMessage("小数点只能输入一次");
                e.Handled = true;
            }
            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0" && (e.KeyChar != 8))
            {
                screen.DisplayMessage("第一位是0，第二位必须是小数点");
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
