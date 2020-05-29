using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20
{
    class Customer
    {
        private string name { get; set; }
        private string tel { get; set; }
        override public string ToString()
        {
            return "客户信息：" + "    " + "客户姓名：" + name + "     " + "客户电话：" + tel;
        }
}
}
