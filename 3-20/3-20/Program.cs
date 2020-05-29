using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public static int num;//订单序号
        public class Order
        {
            private string orderNum;//订单号，获取每日日期和次序组成
            System.Collections.Generic.List<OrderItem> OrderItemlist =
                new System.Collections.Generic.List<OrderItem>();//商品列表
            private Customer customer;//顾客信息
            private double priceAll;//总价            
            public class Customer
            {
                private string name;//名字
                private string state;//职位
            };//顾客类
            public string getOrderNum()
            {
                return orderNum;
            }//获取订单号
            public void setOrderNum()
            {
                DateTime nowtime = DateTime.Now; //当前时间
                //获取月两位数
                string month;
                int month_ = nowtime.Month;
                if (month_ >= 10)
                    month = month_.ToString();
                else month = "0" + month_.ToString();
                //获取天两位数
                string day;
                int day_ = nowtime.Day;
                if (day_ >= 10)
                    day = day_.ToString();
                else day = "0" + month_.ToString();
                //订单数加一
                num++;
                this.orderNum = nowtime.Year.ToString() + month + day + num.ToString();
            }//生成订单号
            public void addOrderItem(Goods goods, int quantity, DateTime deadline, double price)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.Goods = goods;
                orderItem.Price = price;
                orderItem.Quantity = quantity;
                orderItem.Deadline = deadline;
                OrderItemlist.Add(orderItem);
            }//创建明细
            public void deleteOrderItem(Goods goods, int quantity, DateTime deadline)
            {
                foreach (OrderItem oi in OrderItemlist)
                {
                    if ((oi.Goods == goods) && (oi.Quantity == quantity) && (oi.Deadline == deadline))
                        OrderItemlist.Remove(oi);
                }
            }//删除订单明细
            public void deleteOrderItem(Goods goods)
            {
                foreach (OrderItem oi in OrderItemlist)
                {
                    if (oi.Goods == goods)
                        OrderItemlist.Remove(oi);
                }
            }//删除所有相关订单明细
            public Boolean depOrderItem(OrderItem orderItem)
            {
                foreach (OrderItem oi in OrderItemlist)
                {
                    if (oi.Equals(orderItem))
                        return true;
                }
                return false;
            }//订单明细查重,有重复返回1，无重复返回0
        };
        public class OrderItem
        {
            private int _goods;//货物信息编号
            public int Goods { get; set; }
            private int _quantity;//数量
            public int Quantity { get; set; }
            private DateTime _deadline;//截止日期，年月日
            public DateTime Deadline { get; set; }
            private double _price;//单价
            public double Price { get; set; }
            private double _priceTotal;//总价
            public double PriceTotal
            {
                get
                { return _priceTotal; }
                set
                { _priceTotal = _price * _quantity; }
            }
            public bool Equals(OrderItem orderItem)
            {
                return ((this.Goods == orderItem.Goods) && (this.Quantity == orderItem.Quantity)
                    && (this.Deadline.Date == orderItem.Deadline.Date));
            }//重写Equals函数
            public string Tostring()
            {
                string goodinfo;
                return "货物信息" + "\t" + "订单数量" + "\t"
                    + "截止日期" + "\t" + "单价" + "\t"
                    + "总价" + "\t" + "\n" + Goods.ToString() + "\t"
                    + Quantity.ToString() + "\t" + Deadline.ToString() + "\t" +
                    Price.ToString() + "\t" + PriceTotal.ToString() + "\t";
            }//重写Tostring函数 未完成

        };
        public class OrderService
        {
            System.Collections.Generic.List<Order> Orderlist = new System.Collections.Generic.List<Order>();

        };

        static void Main(string[] args)
        {

        }
    }
}
