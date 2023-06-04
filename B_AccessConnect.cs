using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 银行系统;

namespace 银行系统
{
    public class Accesssdata     //数据库类
    {
        private List<AdminiAccount> admini; // 存放账户信息的列表
        Screen screen = new Screen();

            //#这是一个公用使用数据库连接指令#    如果运行不了请改一下下面文件您存放的路径，直接办法是 直接移入D盘做主文件
        public string connectstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\电气223黄河2202010308 银行系统\\银行系统(自创升级版)\\Access数据库\\Bankdatabase.accdb\"";
        public Accesssdata()
        {
            admini = new List<AdminiAccount>();

            // 从数据库加载账户数据
            List<AdminiAccount> loadmanage1 = LoadAmangage();

            // 将加载的账户数据添加到accounts列表中
            admini.AddRange(loadmanage1);
        }

        //更新数据库的钞票数
        public void updatmoneycount(int moneycount)
        {
            int order = 1;
            string updata = "UPDATE Cashdata SET Billnumber='" + moneycount + "' WHERE number= " + order;
            using (OleDbConnection connection = new OleDbConnection(connectstr))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(updata, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                { screen.DisplayMessage("钞票数更新失败，请联系工作人员，但不影响取款" + ex); }
                finally { connection.Close(); }
            }
        }
        //数据库更新密码函数
        public void updatpin(int accountnumber, int pin)
        {    //创建一个密码更新指令
            string updata = "UPDATE Accountdata SET pin='" + pin + "' WHERE accountNumber= " + accountnumber;
            using (OleDbConnection connection = new OleDbConnection(connectstr))   //实例化数据库连接对象
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(updata, connection);  //命令执行更新
                    command.ExecuteNonQuery();//查询数据库操作是否成功
                }
                catch (Exception ex) { screen.DisplayMessage("修改失败，密码无法更新" + ex); }
                finally { connection.Close(); }
            }
        }

        //更新余额
        public void updatabalance(int accountnumber, double availablebalabce, double totalbalance)
        {      //创建一个更新指令
            string updata = "UPDATE Accountdata set availableBalance ='" + availablebalabce + "', totalBalance=" + totalbalance + " WHERE accountNumber=" + accountnumber;
            {
                using (OleDbConnection connection = new OleDbConnection(connectstr))  //实例化数据库连接对象
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(updata, connection);   //命令执行更新
                        command.ExecuteNonQuery();   //查询数据库操作是否成功

                    }
                    catch (Exception ex) { screen.DisplayMessageLine("      取款错误", "请联系银行工作人员" + ex); }
                    finally { connection.Close(); }

                }
            }
        }

        //用于管理者添加数据
        public void InsertAccount(int accountNumber, int pin, double availaBlebalabce, double totalBalance)
        {     //创建一个数据库添加指令
            string add = "INSERT into Accountdata (accountNumber,pin,availableBalance,totalBalance) values(" + accountNumber + "," + pin + "," + availaBlebalabce + "," + totalBalance + ");";
            {
                using (OleDbConnection connection = new OleDbConnection(connectstr))    //实例化数据库连接对象
                {
                    try
                    {
                        connection.Open();    //打开连接对象
                        OleDbCommand command = new OleDbCommand(add, connection);   //创建命令对象，并添加数据入数据库
                        command.ExecuteNonQuery();       //查询数据库操作是否成功
                        screen.DisplayMessage("添加成功");

                    }
                    catch (Exception ex) { screen.DisplayMessageLine("     添加失败", "请联系银行工作人员" + ex); }    //命令操作错误时反馈
                    finally { connection.Close(); }

                }
            }
        }

       
    
      public List<AdminiAccount> LoadAmangage()    // 构造函数，读入管理者数据
      {
        List<AdminiAccount> accounts = new List<AdminiAccount>();
            //创建查询指令
        string query = "SELECT * FROM Adminidata";
        using (OleDbConnection connection = new OleDbConnection(connectstr))   //实例化数据库连接对象
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))       //用命令来查询
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())                  // 遍历结果集,为了AdminiAccount[]通过数据库读取数据
                    {
                        int adminiaccount = Convert.ToInt32(reader["Adminiaccount"]);
                        int adminipin = Convert.ToInt32(reader["Adminipin"]);
                        AdminiAccount admini = new AdminiAccount(adminiaccount, adminipin); // 从结果集中读取管理账户数据
                        accounts.Add(admini);               // 创建AdminiAccount对象并添加到列表中
                    }
                }
               }
             connection.Close();
         }
         return accounts;
      }

        //管理者查询数据库账户信息
        public  DataSet Query(string strquery,params OleDbParameter[] para)
        { 
            using (OleDbConnection connection = new OleDbConnection(connectstr))      //实例化数据库连接对象
            {
                using (OleDbCommand command = new OleDbCommand(strquery, connection))     //执行数据库查询
                { 
                    DataSet dataSet = new DataSet();     //新建表对象
                    try
                    {
                        if(para != null)
                        {
                            foreach (OleDbParameter p in para)
                            {
                                command.Parameters.AddWithValue(p.ParameterName, p.Value);
                            }
                        }
                        OleDbDataAdapter oleDb = new OleDbDataAdapter(command);   //创建设配器对象
                        oleDb.Fill(dataSet);      //用设配器对象填充表对象
                        return dataSet;    //将表传出
                    }
                    catch (Exception ex) { return null; }    //出错时传空字符
                    return dataSet;    
                }
            }
        }

        //用于管理者修改客户信息
        public void updatabalance(int pin, double availablebalabce, double totalbalance, int accountnumber)
        {
            //更新操作指令
            string updata = "UPDATE Accountdata set pin='"+pin+"', availableBalance =" + availablebalabce + ", totalBalance=" + totalbalance + " WHERE accountNumber=" + accountnumber;
            {
                using (OleDbConnection connection = new OleDbConnection(connectstr))    //实例化数据库连接对象
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(updata, connection);     //更新数据库信息
                        command.ExecuteNonQuery();
                        screen.DisplayMessage("修改成功");
                    }
                    catch (Exception ex) { screen.DisplayMessageLine("      修改失败", "请联系银行工作人员" + ex); }  //获取更新失败分析
                    finally { connection.Close(); }

                }
            }
        }

        //用于管理员删除数据
        public void Deletedata(int accountnumber)
        {
            string deleteaccount = "delete from Accountdata where accountNumber=" + accountnumber;
            {
                using (OleDbConnection connection = new OleDbConnection(connectstr))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(deleteaccount, connection);
                        command.ExecuteNonQuery();
                        screen.DisplayMessage("删除成功");
                    }
                    catch (Exception ex) { screen.DisplayMessageLine("      修改失败", "请联系银行工作人员" + ex); }
                    finally { connection.Close(); }

                }
            }
        }
        public bool AuthenticateAdmini(int adminiaccount, int adminipin)     //管理者身份验证是否正确
        {

            foreach (AdminiAccount manage in admini)   //采用遍历数据库方式查找
            {
                if (manage.adminiaccount == adminiaccount && manage.adminipin == adminipin)
                {
                    return true;
                }
            }
            return false;
        }
    }
  public class AdminiAccount
  {
    public int adminiaccount;// 账户号码
    public int adminipin; // 账户密码
    //构建管理者的数据类
    public AdminiAccount(int adminiaccount, int adminipin)   //构造管理者账户函数
    {
        this.adminiaccount = adminiaccount;
        this.adminipin = adminipin;
    }
  }
}

