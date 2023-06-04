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
    public partial class ZZZManage : Form
    {
        private bankfirst bankfirst1;
        private ZZZadd zZZadd;
        private Screen screen;
        public Accesssdata accesssdata;
        public ZZZManage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();     //退出时关闭此界面回到登录界面
            bankfirst1.Show();

        }

        private void ZZZManage_Load(object sender, EventArgs e)
        {
            bankfirst1 = new bankfirst();       //将各个需要用到的功能实例化
            zZZadd = new ZZZadd();
            screen = new Screen();
            accesssdata = new Accesssdata();
            string constr = "select * from Accountdata";       
            DataSet ds = accesssdata.Query(constr);        //将数据导入数据列表中
            if (ds != null && ds.Tables.Count > 0)       //判别是否为空，为空就不导入
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zZZadd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;       //导入Account数据
            if (row == null)          //判断是否选择了修改的行
            {
                screen.DisplayMessage("请选择您要修改的信息");
                return;
            }
            Yonghu yonghu = new Yonghu();
            yonghu.order = transferInt(row.Cells["order"].Value);                  // 把数据传入一个公用数据暂放器，便于传递
            yonghu.accountNumber = transferInt(row.Cells["accountNumber"].Value);
            yonghu.pin = transferInt(row.Cells["pin"].Value);
            yonghu.availableBalance = transferDouble(row.Cells["availableBalance"].Value);
            yonghu.totalBalance = transferDouble(row.Cells["totalBalance"].Value);
            ZZZadapt zZZadapt = new ZZZadapt(yonghu);      //将公用暂放器的数据传入修改窗口
            zZZadapt.Show();

        }
        public double transferDouble(object str)
        {
            double i = 0.00;                //封装一个将字符串转换为double类型的方法
            if (str != null)
            {
                double.TryParse(str.ToString(), out i);
            }
            return i;
        }
        public int transferInt(object str)
        {
            int result = 0;            //封装一个将字符串转换为Int类型的方法，这里就不用keypad，因为它的错误返回值被设定为-1
            if (str != null)
            {
                int.TryParse(str.ToString(), out result);
            }
            return result;
        }

        private void Tip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            screen.DisplayMessage("1、点击您要修改的项目\n2、然后点击您要操作的执行按钮\n3、根据用户需求修改即可\n4、后刷新数据核验\n");    //操作提示
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btupdate_Click(object sender, EventArgs e)      
        {
            string constr = "select * from Accountdata";       //更新表格数据，制定数据刷新按钮
            DataSet ds = accesssdata.Query(constr);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;       //导入Account数据
            if (row == null)          //判断是否选择了修改的行
            {
                screen.DisplayMessage("请选择您要删除的账户信息");      
                return;
            }
            Yonghu yonghu = new Yonghu();   //实例化和Account类型一致的暂放器
            yonghu.accountNumber = transferInt(row.Cells["accountNumber"].Value);       
            accesssdata.Deletedata(yonghu.accountNumber);         //根据账号进行删除
        }
    }
}
