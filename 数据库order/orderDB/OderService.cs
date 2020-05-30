using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12orderDB
{
    class OderService
    {
        public static List<Order> orderlist = new List<Order>();
        public static DBconn dBconn = new DBconn();

        public static void Addorder(Order ord,Custom custom)
        {
            dBconn.Addorder(custom, ord);
            Console.WriteLine("订单添加成功");
        }
        public static void Delete(Order ord)
        {
            dBconn.Deleteorder(ord);
            Console.WriteLine("订单删除成功");
        } 
        public static void Print()
        {
            dBconn.Printorder();
        }
    }
}
