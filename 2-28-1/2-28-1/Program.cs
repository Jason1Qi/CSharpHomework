using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Prime
{ 
    public static int ReturnFirstDivisor(int division)//输入一个数，返回这个数的最小的因数
{
    int divisor = 0;
    for (int i = 2; i <= division; i++)
    {
        if (division % i == 0)
        {
            divisor = i;
            break;
        }
    }
    return divisor;
}
    public static int PrintDivisor(int division)//输入一个数，返回这个数除完最小因数的结果
    {
        int divisor = 0;
        for (int i = 2; i <= division; i++)
        {
            if (division % i == 0)
            {
                divisor = i;
                break;
            }
        }
        return division / divisor;
    }
    static void Main(string[] args)

    {
        Console.WriteLine("请输入需要打印素数因子的数");
        int userInput = Convert.ToInt32(Console.ReadLine());
        for(int i= userInput; ReturnFirstDivisor(i)!=0;i= PrintDivisor(i))
            Console.WriteLine(ReturnFirstDivisor(i));
    Console.ReadLine();
    }
}