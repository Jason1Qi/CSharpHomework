using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20
{
    class Order
    {
        private List<OrderItem> itemlist;
        private Customer customer;
        private string number;
        public void setNumber()
        {
            this.number=
        }
        public override string ToString()
        {
            string returnstring="";
            foreach(OrderItem orderItem in itemlist)
            {
                returnstring += orderItem.ToString()+"/n/n";
            }
            returnstring += customer.ToString();
            return returnstring;
        }
        public bool Equals(Order order)
        {

            if (this.customer != order.customer)
                return false;
            else if (this.itemlist.Count != order.itemlist.Count)
                return false;
             int equals = 1;
                for (int i = 0; i < itemlist.Count; i++)
            {
                if (this.itemlist[i].Equals(order.itemlist[i]))
                    equals = 0;
                else break;
            }              
             if (equals == 0)
                        return false;
                else
                    return true;
        }
    }
}
