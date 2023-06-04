namespace 银行系统
{
    public partial class BankMain : Form
    {
        public BankMain bankmain;
        public bankfirst bankfirst1;
        public bankTransaction transaction;
        public ChangedPassord changedPassord;
        public bankTranster transter;
        public BankDeposit bankDeposit;
        public Keypad keypad;
        public Screen screen;
        public int control = 0;
        public int control2;
        public B_ATM tM;
        public int InputaccountNumber;
        public void accountNumber(int accountNumber)
        { InputaccountNumber = accountNumber; }
        public BankMain()
        {
            InitializeComponent();

        }
        private void BankMain_Load(object sender, EventArgs e)
        {
            bankfirst1 = new bankfirst();                               //将各个窗体以及ATM的功能组装进来
            transaction = new bankTransaction();
            transter = new bankTranster();
            tM = new B_ATM();
            changedPassord = new ChangedPassord();
            bankDeposit = new BankDeposit();
            keypad = new Keypad();
            screen = new Screen();
            transaction.accountNumber(InputaccountNumber);              //将用户账号传入bankTransaction窗体
            changedPassord.accountNumber(InputaccountNumber);           //将用户账号传入ChangedPassord窗体
            transter.accountNumber(InputaccountNumber);                 //将用户账号传入Transter窗体
            bankDeposit.accountNumber(InputaccountNumber);              //将用户账号传入BankDeposit窗体

        }

        private void button4_Click(object sender, EventArgs e)
        {
            control = 5;                                                //转账
            control2 = -1;   //初始操作值
            this.Hide();
            transter.Show();
            tM.Run(InputaccountNumber, control, control2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            control = 7;                                           //执行退卡，关闭此界面，回到登录界面
            control2 = -1;   //初始操作值
            this.Close();
            bankfirst1.Show();
            tM.Run(InputaccountNumber, control, control2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control = 1;                                               //执行取款
            control2 = -2;   //初始操作值
            tM.Run(InputaccountNumber, control, control2);
            this.Hide();
            transaction.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            control = 6;                                               //执行更改密码
            control2 = -1;
            tM.Run(InputaccountNumber, control, control2);
            this.Hide();
            changedPassord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control = 3;                                              //执行余额查询
            control2 = -1;      //初始操作值
            tM.Run(InputaccountNumber, control, control2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control = 4;                                            //同样具有退卡功能的返回键
            control2 = -1;   //初始操作值
            this.Close();
            bankfirst1.Show();
            tM.Run(InputaccountNumber, control, control2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            control = 2;                                            //执行存款
            control2 = -1;   //初始操作值
            tM.Run(InputaccountNumber, control, control2);
            this.Hide();
            bankDeposit.Show();
        }
    }
}