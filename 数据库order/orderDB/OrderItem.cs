using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12orderDB
{
    class OrderItem
    {
        public string name_item;
        public int number_item;
        public double price;
        public OrderItem() { }
        public OrderItem(string c, int n, double p)
        {
            name_item = c;
            number_item = n;
            price = p;
        }
        public string Name_item { get { return this.name_item; } }
        public int Number_item { get { return this.number_item; } }
        public double Price { get { return this.price; } }
    }
}
