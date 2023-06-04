using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行系统
{
    public class Yonghu      //建立一个数据类型暂存对象，便于调用
    {
        public int order { get; set; }
        public int accountNumber { get; set; }
        public int pin { get; set; }
        public double availableBalance { get; set; }
        public double totalBalance { get; set; }

    }
}
