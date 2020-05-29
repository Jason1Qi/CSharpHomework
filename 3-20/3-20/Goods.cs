using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20
{
    class Goods
    {
        private string name { get; set; }
        private string number { get; set; }
        override public string ToString()
        {
            return "货物信息：" + "    " + "货物名称：" + name + "     " + "货号：" + number;
        }
    }
}
