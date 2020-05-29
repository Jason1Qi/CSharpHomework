using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20
{
    class OrderItem
    {
        private Goods _goods { get; set; }
        private int _quantity{ get; set; }
        override public string ToString()
        {
            return "订单明细："+"/n"+"货物信息"+this._goods.ToString()
                +"/n"+"订单数量"+_quantity;
        }//重写字符串函数
        public bool Equals(OrderItem orderItem)
        {
            return ((this._goods.ToString() == orderItem._goods.ToString()) 
                && (this._quantity == orderItem._quantity));
        }//重写Equals函数
    }
}
