// Transaction类表示一个交易，是一个抽象类，具有抽象方法Execute()，被Withdrawal类、Deposit类和BalanceInquiry类继承
using System.Data.OleDb;
using 银行系统;

public abstract class B_Transaction
{
    // 账户号码
    private int accountNumber;
    // 用户界面
    private Screen userScreen;
    // 银行数据库
    private BankDatabase database;

    // 3个参数的构造函数，用于初始化上述3个属性
    public B_Transaction(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase)
    {
        accountNumber = userAccountNumber;
        userScreen = atmScreen;
        database = atmBankDatabase;
    }

    // 返回账户号码
    public int AccountNumber
    {
        get
        {
            return accountNumber;
        }
    }

    // 返回用户界面
    public Screen UserScreen
    {
        get
        {
            return userScreen;
        }
    }

    // 返回银行数据库
    public BankDatabase Database
    {
        get
        {
            return database;
        }
    }
   

    // 抽象方法，由子类实现
    public abstract void Execute(int input);

    
}
// BalanceInquiry类用于显示账户余额的操作
class BalanceInquiry : B_Transaction
{
    // 构造函数
    public BalanceInquiry(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase)
        : base(userAccountNumber, atmScreen, atmBankDatabase)
    {
    }

    // 执行账户余额操作
    public override void Execute(int accountNumber)
    {
        if (accountNumber != null)
        {
            // 获取银行数据库和ATM屏幕
            BankDatabase bankDatabase = Database;
            Screen screen = UserScreen;

            // 获取账户余额
            decimal availableBalance = (decimal)bankDatabase.GetAvailableBalance(AccountNumber);
            decimal totalBalance = (decimal)bankDatabase.GetTotalBalance(AccountNumber);

            // 在ATM屏幕上显示余额信息
            screen.DisplayMessageLine("账户余额信息：", $"    总余额： {totalBalance:C}\n 可用余额： {availableBalance:C}");
        }
    }
}
public class Withdrawal : B_Transaction
{
    private double amount; // 取款金额
    private Keypad keypad; // ATM 机键盘
    private CashDispenser cashDispenser; // ATM 机现金发放器
    private const int CANCELED = 6;
    private Screen screen;

    // 金额选项
    private double [] amounts = { 0, 100,200, 500, 1000, 2000 };

    // 构造函数
    public Withdrawal(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase, Keypad atmKeypad, CashDispenser atmCashDispenser)
        : base(userAccountNumber, atmScreen, atmBankDatabase)
    {
        keypad = atmKeypad;
        cashDispenser = atmCashDispenser;
        screen= atmScreen;
    }

    // 执行取款操作
    public override void Execute(int input)
    {
        if (input != -2)
        {
            int selection = DisplayMenuOfAmounts(input);// 显示取款金额菜单并获取用户的选项
            if (selection != -1)      //判断选择值是否为交易选项
            {
                if (selection != 6 && selection < 6)    // 检查用户是否选择了取款金额或取消交易
                {
                    // 设置取款金额为用户所选金额
                    amount = amounts[selection];
                    // 获取用户账户余额
                    double availableBalance = Database.GetAvailableBalance(AccountNumber);
                    // 检查用户账户余额是否足够
                    if (amount <= availableBalance)
                    {
                        // 检查 ATM 机内是否有足够现金
                        if (cashDispenser.IsSufficientCashAvailable(amount))
                        {
                            // 让用户确认取款金额是否正确
                            if (userConfirmsTransaction(amount))
                            {
                                // 更新账户余额
                                Database.Debit(AccountNumber, (amount));
                                // 发放现金，更新钞票数
                                cashDispenser.DispenseCash(amount);
                                // 显示取款成功信息
                                screen.DisplayMessageLine("取款成功", "请及时取走你的现金！");
                            }
                            else
                            {
                                // 用户取消交易
                                screen.DisplayMessage("操作已取消！");
                            }
                        }
                        else
                        {
                            // ATM 机内现金不足
                            screen.DisplayMessageLine("ATM 机内现金不足\n取款失败！", "请及时联系工作人员");
                        }
                    }
                    else
                    {
                        // 用户账户余额不足
                        screen.DisplayMessageLine("对不起！", "您账户的余额不足");
                    }
                }
                else
                {
                    // 用户选择取消交易
                    screen.DisplayMessageLine("交易已取消", "感谢您的光临");
                }
            }
        }
    }

    //确认交易金额
   private bool userConfirmsTransaction(double amount) 
    {
        screen.DisplayMessage($"取款金额为：${amount:F2}");
        return true;
    }


    // 显示取款金额菜单并获取用户的选项
    private int DisplayMenuOfAmounts(int input1)
    {

        int userChoice = 0; // 用户选择的选项
        if (input1 != 123456)
        {
            switch (input1)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    userChoice = input1;
                    break;
                case CANCELED:
                    userChoice = CANCELED;
                    break;
                default:
                    userChoice = -1;
                    screen.DisplayMessageLine("没有你输入的选项", "请再次输入");
                    break;
            }
        }
            return userChoice; // 返回用户选择的选项
        }
}

public class CashDispenser
{
    private int INITIAL_COUNT ; // 初始钞票数量为500张
    private int billCount; // 现存钞票数量
    Accesssdata accesssdata=new Accesssdata();

    // CashDispenser类构造函数
    public CashDispenser()
    {   
        //为了确保钞票数量发生变化，这里引用数据库Billcount=500;
        string query = "SELECT * FROM Cashdata";
        using (OleDbConnection connection = new OleDbConnection(accesssdata.connectstr))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read()) { INITIAL_COUNT = Convert.ToInt32(reader["Billnumber"]); }
                }
            }
            connection.Close();
            billCount = INITIAL_COUNT;     //把钞票数转换变量
        }
    }
    // 检查ATM是否有足够的钞票
    public bool IsSufficientCashAvailable(double amount)
    {
        int billsRequired = Convert.ToInt32(amount) / 10; // 需要的钞票数
        return (billCount >= billsRequired); // 如果现有钞票数量大于所需数量，返回true
    }

    // 取钞
    public void DispenseCash(double amount)
    {
        int billsRequired = Convert.ToInt32(amount) / 100; // 需要的钞票数
        billCount -= billsRequired; // 减去所需的钞票数量
        //更新钞票数
        accesssdata.updatmoneycount(billCount);
       
    }
}

