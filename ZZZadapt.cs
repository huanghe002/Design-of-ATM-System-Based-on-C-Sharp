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
    public partial class ZZZadapt : Form
    {
        private ZZZManage zZManage;
        private Keypad keypad;
        private Screen screen;
        private BankDatabase bankDatabase;
        private Accesssdata accesssdata;
        public ZZZadapt(Yonghu yonghu)
        {
            InitializeComponent();
            if (yonghu != null)
            {
                textorder.Text = yonghu.order.ToString();
                textAccount.Text = yonghu.accountNumber.ToString();
                textPin.Text = yonghu.pin.ToString();
                textAvailablebalance.Text = yonghu.availableBalance.ToString();
                textTotalbalance.Text = yonghu.totalBalance.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //判断是否为提交的修改信息
            if (string.IsNullOrEmpty(textPin.Text) && string.IsNullOrEmpty(textAvailablebalance.Text) && string.IsNullOrEmpty(textTotalbalance.Text) && string.IsNullOrEmpty(textorder.Text))
            {
                screen.DisplayMessageLine("添加失败", "请将信息填写完整后再按添加键");
            }
            else
            {
                int accountnumber = keypad.GetInput(textAccount.Text);         //转换为Account类型
                int addPin = keypad.GetInput(textPin.Text);
                double addavailableBalance = Convert.ToDouble(textAvailablebalance.Text);
                double addtotalBalance = Convert.ToDouble(textTotalbalance.Text);
                if (addavailableBalance <= addtotalBalance)           //判断修改的可用余额是否小于或等于总余额
                {
                    accesssdata.updatabalance(addPin, addavailableBalance, addtotalBalance, accountnumber);   //操纵数据库执行修改
                    this.Hide();
                }
                else
                {
                    screen.DisplayMessageLine("添加失败", "可用余额大于总余额\n请重新输入可用余额和总余额");
                    textAvailablebalance.Text = ""; textTotalbalance.Text = "";
                }
            }
        }

        private void ZZZadapt_Load(object sender, EventArgs e)
        {
            zZManage = new ZZZManage();             //将各个需要使用的功能实例化
            keypad = new Keypad();
            screen = new Screen();
            bankDatabase = new BankDatabase();
            accesssdata = new Accesssdata();
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
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != (char)('.'))      //输入金额设定规则，限制输入字符类型
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
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != (char)('.'))      //输入金额设定规则，限制输入字符类型
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
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == (char)('.'))    //限制输入，仅输入为数字和删除
            {
                e.Handled = false;
            }
        }

        private void textTotalbalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
