using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace day12orderDB
{
    class Program
    {
    
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("当前客户：客户1；当前订单号：302");
            Custom custom = new Custom("客户1");
            Order order = new Order( "302");

            OderService.Addorder(order,custom);

            OrderItem item = new OrderItem("水仙",3,18.4);
            order.Additem(item);

            
            OderService.Print();
            OderService.Delete(order);
        }
    }
}
