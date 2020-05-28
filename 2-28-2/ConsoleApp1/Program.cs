using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4

{

    class Program

    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(random.Next()%100);
            }
            foreach(int i in a)
            {
                Console.Write(i+"  ");
            }
            int max = a[0];
            int min = a[0];
            int sum = 0;
            float ave = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
                sum += a[i];
            }
            float s = sum;
            ave = s / 100;
            Console.WriteLine("");
            Console.WriteLine(max.ToString() + "  " + min.ToString() + "  " +
                sum.ToString() + "  " + ave.ToString());
            Console.ReadLine();
        }
    }
}
