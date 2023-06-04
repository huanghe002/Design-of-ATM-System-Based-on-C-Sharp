using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using 银行系统;

public class B_ATM
{
    private bool userAuthenticated; // 用户是否已通过身份验证
    private int currentAccountNumber; // 当前帐户号码
    private Screen screen; // ATM屏幕
    private Keypad keypad; // ATM键盘
    private CashDispenser cashDispenser; // 现金分配器
    private DepositSlot depositSlot; // 存款槽
    private BankDatabase bankDatabase; // 银行数据库
    public int control1;
    public int control2;

    // 构造函数初始化ATM的各个组件,方便调用各个数据
    public B_ATM()
    {
        currentAccountNumber = 0;
        screen = new Screen();
        keypad = new Keypad();
        cashDispenser = new CashDispenser();
        depositSlot = new DepositSlot();
        bankDatabase = new BankDatabase();
        userAuthenticated = false;
    }

    // 用户身份验证
    public int AuthenticateUser(int accountNumber, int pin)
    {


        userAuthenticated = bankDatabase.AuthenticateUser(accountNumber, pin);

        if (userAuthenticated)
        {
            currentAccountNumber = accountNumber;
            return currentAccountNumber;      //用户存在且验证成功后得到账户账号
        }
        else
        {
            return 0;
        }
    }

    // 显示主菜单
    public void DisplayMainMenu()
    {
        screen.DisplayMessageLine("  欢迎进入  ", " 中国农业银行");
    }

    // 执行用户选择的交易
    private void PerformTransaction(int control1,int control2)
    {
        B_Transaction currentTransaction = null;

        switch (control1)
        {


            case 1: // 取款
                currentTransaction = new Withdrawal(currentAccountNumber, screen, bankDatabase, keypad, cashDispenser);
                currentTransaction.Execute(control2);
                break;
            case 2: // 存款
                currentTransaction = new B_Deposit(currentAccountNumber, screen, bankDatabase, keypad, depositSlot);
                if (control2 != -1)    //来个初始条件，方便引用判断  
                {
                    currentTransaction.Execute(control2);
                }
                break;
            case 3: // 余额查询
                currentTransaction = new BalanceInquiry(currentAccountNumber, screen, bankDatabase);
                currentTransaction.Execute(currentAccountNumber);
                break;
            case 4: //返回即退卡
                screen.DisplayMessageLine("您已安全退出", "农业银行为你保驾护航");
                break;
            case 5://转账
                screen.DisplayMessage("请您再三确定对方账号，切勿轻信可以来电");
                break;
            case 6://修改密码
                break;
            case 7: // 退出
                screen.DisplayMessageLine("   您已安全退出  ", "农业银行为你保家护航");
                break;
            default: // 用户输入了无效的选项
                screen.DisplayMessage("选择无效");
                break;
        }
    }
    public void Run(int inputNumber,int control1,int control2) 
    {
        currentAccountNumber = inputNumber;
        PerformTransaction(control1,control2);
    }
}
    public class Screen
    {
        // 显示一条消息
        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        // 显示一条消息并换行
        public void DisplayMessageLine(string message1, string message2)
        {
            string message = message1 + "\n" + message2;
            MessageBox.Show(message);
        }

        // 显示一个带有美元符号的金额
        public void DisplayDollarAmount(double amount)
        {
            MessageBox.Show($"${amount:F2}");
        }
    }
public class Keypad
{
        // 返回用户输入的整数
   public int GetInput(string userInput)
   {
        Screen screen = new Screen();
        int input = 0; // 存储用户输入的整数
        if (Convert.ToInt32(userInput) >=0)     //判断是否为整整数
        {
            // 将用户输入的字符串转换为整数，如果转换失败则提示用户重新输入
            if (!int.TryParse(userInput, out input))
            {
                screen.DisplayMessage("请输入整型");
                return -1;
            }
            else return input;
        }
        else
        { 
            screen.DisplayMessage("请输入正整数");
            return -1;
        }
   }
}

