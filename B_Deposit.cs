using System;
using 银行系统;


public class B_Deposit:B_Transaction
{
    private double amount; // 存款金额
    private Keypad keypad; 
    private Screen screen;
    private DepositSlot depositSlot; // 存款槽
    private const int CANCELED = 0; // 取消操作代码
    private int accountNumber;//用户账号
    

    // Deposit类构造函数
    public B_Deposit(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase, Keypad atmKeypad, DepositSlot atmDepositSlot) : base(userAccountNumber, atmScreen, atmBankDatabase)
    {
        keypad = atmKeypad;
        depositSlot = atmDepositSlot;
        accountNumber = userAccountNumber;
        screen = atmScreen;

    }

    

    // 执行存款
    public override void Execute(int save)
    {
        amount = keypad.GetInput((PromptForDepositAmount(save)).ToString()); // 获取存款金额,并查看是否为整型
        bool envelopeReceived = depositSlot.IsDepositEnvelopeReceived(save); // 检查存款是否收到

        // 如果存款金额存款收到时
        if (envelopeReceived)
        {
            if (amount != CANCELED)
            {

                // 显示提示信息并将存款封装
                screen.DisplayMessage($"您的存款金额为：${save:F2}");
                BankDatabase bankDatabase = new BankDatabase();
                // 存款成功后，将存款封装存入BankDatabase中
                bankDatabase.Credit(accountNumber, amount);
                screen.DisplayMessageLine("存款成功","继续存款请继续操作，退出按返回键");
            }
            else 
            {
                screen.DisplayMessage("您的钞票含有不为100元的大钞，请取出后在存款");
            }
        }
        else { screen.DisplayMessageLine("您还没有放存款进入取款机", "如要存款请将纸币整理齐后放入纸币"); }
    }


    // 提示用户输入存款金额
    private double PromptForDepositAmount(float save)
    {
        int i;
        float money = save / 100;    // 将存款金额从分转换为人名币
        i =Convert.ToInt32(money);
        if (money%1==0)         //检测存款是否为不是100元的大钞倍数
        {
            if (save == CANCELED)
            {
                return CANCELED;
            }
            else
            {
                return i;
            }
        }
        else { return CANCELED; }       //不是时返回CANCELED
    }
}
public class DepositSlot
{
    private bool envelopeReceived; // 用于检测是否有存款信封到达

    // DepositSlot 的构造函数
    public DepositSlot()
    {
        envelopeReceived = false; // 初始化为未接收到存款信封
    }
    
    public bool IsDepositEnvelopeReceived(double save)
    {
        if(save!=0)envelopeReceived = true;        //当存款金额不为0是，存款信封被接收（low了点，因为没有真的人民币输入）
        else  envelopeReceived = false;     
   
        if (envelopeReceived)      //检测结果为收到
        {
            return true;
        }
        else                      //检测结果为没有收到
        {
            return false;
        }
    }
}
