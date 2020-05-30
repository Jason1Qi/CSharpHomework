using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12orderDB
{
    class Order
    {
        public string number_order;
        public DBconn dBconn = new DBconn();
        public Order() { }
        public Order(string s)
        {
            number_order = s;
        }
        public void Additem(OrderItem orderItem)
        {
            dBconn.AddItem(orderItem.Name_item, orderItem.number_item, orderItem.price,this.number_order);
            //订单号作为外键
            Console.WriteLine($"{orderItem.Name_item}商品添加成功");
        }

    }
}
