using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace 银行系统
{
    public class BankDatabase
    { // 存放账户信息的数组
        private List<Account> accounts; // 存放账户信息的列表
        Accesssdata accesssdata= new Accesssdata();
                                        
        public List<Account> LoadAccountsFromDatabase()    // 构造函数，初始化账户信息,为了确保实时更新，这里采用数据库读入
        {
            List<Account> accounts = new List<Account>();

            // 建立数据库连接
            string query = "SELECT * FROM Accountdata";
            using (OleDbConnection connection = new OleDbConnection(accesssdata.connectstr))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())                  // 遍历结果集,为了Account[]通过数据库读取数据
                        {
                            int accountNumber = Convert.ToInt32(reader["accountNumber"]);
                            int pin = Convert.ToInt32(reader["pin"]);
                            double availableBalance = Convert.ToDouble(reader["availableBalance"]);
                            double totalBalance = Convert.ToDouble(reader["totalBalance"]);
                            Account account = new Account(accountNumber, pin, availableBalance, totalBalance); // 从结果集中读取账户数据
                            accounts.Add(account);               // 创建Account对象并添加到列表中
                        }
                    }
                }
                connection.Close();
            }
            return accounts;
        }

        public BankDatabase()
        {
            accounts = new List<Account>();

            // 从数据库加载账户数据
            List<Account> loadedAccounts = LoadAccountsFromDatabase();

            // 将加载的账户数据添加到accounts列表中
            accounts.AddRange(loadedAccounts);
        }

        // 根据账号返回对应的账户对象，若未找到则返回null
        public Account GetAccount(int accountNumber)
        {
            
            foreach (Account account in accounts)    //遍历账户数据
            {
                if (account.accountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        // 校验账户和密码是否匹配，若匹配则返回true,不匹配则返回false
        public bool AuthenticateUser(int accountNumber, int pin)
        {
            foreach (Account account in accounts)
            {
                if (account.accountNumber == accountNumber && account.pin == pin)  //遍历数据，看是否符合
                {
                    return true;
                }
            }

            return false;
        }

        // 获取账户的可用余额
        public double GetAvailableBalance(int accountNumber)
        {
            Account account = GetAccount(accountNumber); // 获取账户对象
            if (account != null)
            {
                return account.availableBalance;
            }
            else
            {
                return -1;
            }
        }

        // 获取账户的总余额
        public double GetTotalBalance(int accountNumber)
        {
            Account account = GetAccount(accountNumber); // 获取账户对象
            if (account != null)
            {
                return account.totalBalance;
            }
            else
            {
                return -1;
            }
        }
    
        //修改密码
        public bool Changepassword(int accountNumber,int newPin,int OldPin)
        {
            Screen screen=new Screen();
            Account account = GetAccount(accountNumber);
            if (account != null && account.ValidatePin(OldPin))
            {
                    foreach (Account account2 in accounts)
                    {
                        if (account2.pin == OldPin)
                        {
                            // 找到匹配的PIN码后，修改对应的属性值
                            account2.pin = newPin;
                            accesssdata.updatpin(accountNumber,account2.pin);//更新密码
                            break;  // 找到后可以结束循环
                        }
                    }
                return true;
            }
            else
            {
                return false;
            }
        }
        // 向账户中存入指定金额
        public void Credit(int accountNumber, double amount)
        {
            Account account = GetAccount(accountNumber); // 获取账户对象
            if (account != null)
            {
                account.Credit(accountNumber, amount);    //执行账户转入RMB
            }
        }

        // 从账户中取出指定金额
        public void Debit(int accountNumber, double amount)
        {
            Account account = GetAccount(accountNumber); // 获取账户对象
            if (account != null)
            {
                account.Debit(accountNumber,amount);  //执行账户转出RMB
            }
        }
    }
    public class Account
    {
        public int accountNumber;// 账户号码
        public int pin; // 账户密码
        public double availableBalance;  // 可用余额
        public double totalBalance;  // 总余额

        // 构造函数
        public Account(int accountNumber, int pin, double availableBalance, double totalBalance)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.availableBalance = availableBalance;
            this.totalBalance = totalBalance;
        }
        // 获取账户号码
        public int AccountNumber(int accountNumber1)
        {
            if(accountNumber==accountNumber1)return accountNumber;
            else return -1;
        }

        // 获取可用余额
        public double AvailableBalance(double availableBalance)
        {
           
            return availableBalance;
        }
        // 获取总余额
        public double TotalBalance()
        {
            return totalBalance;
        }
        public bool ValidatePin(int userPin)
        {
            if (pin == userPin)return pin == userPin;
            else return false;
        }

        // 存款
        public void Credit(int accountnumber,double amount)
        {
            Accesssdata accesssdata = new Accesssdata();
            availableBalance += amount;
            totalBalance += amount;
            accesssdata.updatabalance(accountNumber,availableBalance,totalBalance);//存款后更新数据库余额
        }

        // 取款
        public void Debit(int accountnumber, double amount)
        {
            Accesssdata accesssdata = new Accesssdata();
            availableBalance -= amount;
            totalBalance -= amount;
            accesssdata.updatabalance(accountnumber,availableBalance,totalBalance);//取款后更新数据库余额
        }
    }
}
