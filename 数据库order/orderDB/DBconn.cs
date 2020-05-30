using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace orderDB
{
    class DBconn
    {
        public static MySqlConnection connection;

        public DBconn()
        {
            connection = GetConnection();
        }
        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=12345678;database=order_system;charset=utf8");
            connection.Open();
            return connection;
        }

        //选购某一项商品
        public void AddItem(string name,int number,double price,string id)
        {
            using (MySqlCommand cmd = new MySqlCommand
                ("INSERT INTO item(iname,inumber,price,order_id) VALUES(@name,@number,@price,@id)", connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }

        //客户下单
        public void Addorder(Custom custom, Order order)
        {
            using (MySqlCommand cmd = new MySqlCommand
                ("INSERT INTO orderlist(cus_name,order_name) VALUES(@cus_name,@order_name)", connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cus_name", custom.Name_cus);
                cmd.Parameters.AddWithValue("@order_name", order.number_order);

                cmd.ExecuteNonQuery();
            }

        }

        //删除订单
        public void Deleteorder(Order order)
        {
            using (MySqlCommand cmd = new MySqlCommand
                ("DELETE  FROM  orderlist  WHERE  order_name=@order_name", connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@order_name", order.number_order);
                cmd.ExecuteNonQuery();
            }
            using (MySqlCommand cmd = new MySqlCommand
                ("DELETE  FROM  item  WHERE  order_id=@order_name", connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@order_name", order.number_order);
                cmd.ExecuteNonQuery();
            }
        }
        //展示订单
        public void Printorder()
        {
            string stm = "SELECT * FROM orderlist";
            using (MySqlCommand cmd = new MySqlCommand(stm, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //逐行读取
                        Console.WriteLine("顾客："+ reader.GetValue(0));
                        Console.WriteLine("订单：" + reader.GetValue(1));
                    }
                }
            }

        }

    }
}
