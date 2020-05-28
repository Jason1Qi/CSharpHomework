using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28_3
{
    class Program
    {
        //用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再
        //去掉4的倍数，以此类推...最后剩下的就是素数。
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            int[] divisor = new int[9];
            for(int i=2;i<=100;i++)
            {
                array.Add(i);
                if (i <= 10)
                    divisor[i-2] = i;
            }
            foreach(int i in divisor)
            {
                for(int j=0;j<array.Capacity;j++)
                {
                    if(Convert.ToInt32(array[j])%i==0)
                        array.RemoveAt(j);
                    array.TrimToSize();
                }
            }
            foreach(int i in array)
            Console.Write(i+"   ");
            Console.ReadLine();
        }
    }
}

