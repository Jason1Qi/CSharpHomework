using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericApplication
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {tail = head = null;}
        public Node<T> Head
        {get => head;}
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> t = this.head;
            while (t != null)
            {
                action(t.Data);
                t = t.Next;
            }
        }
    }
    class Program

    {

        static void Main(string[] args)
        {
            // 整型List
            Random random = new Random();
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(random.Next(10));
            }
            //打印
            intlist.ForEach(x => Console.WriteLine(x));
            int max = int.MinValue;
            int min = int.MaxValue;
            intlist.ForEach(x =>
            {
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            });
            int sum = 0;
            intlist.ForEach(x => { sum = sum + x; });
            Console.WriteLine("最大项：" + max +"   "+
                              "最小数：" + min+ "   "+
                              "求和结果：" + sum+"   ");
            Console.Read();
        }

    }

}