using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入参与计算的数字");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入+,-,*,/中的运算符");
                    string ss = Console.ReadLine();
                    Console.WriteLine("请输入另一个：");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    switch (ss)
                    {
                        case "+":
                            double n11 = n1 + n2;
                            Console.WriteLine("加法，结果为" + n11);
                            break;
                        case "-":
                            double n12 = n1 - n2;
                            Console.WriteLine("减法，结果" + n12);
                            break;
                        case "*":
                            double n13 = n1 * n2;
                            Console.WriteLine("乘法，结果为" + n13);
                            break;
                        case "/":
                            while (n2 == 0)
                            {
                                Console.WriteLine("请输入一个非零数");
                               n2 = Convert.ToInt32(Console.ReadLine());
                            }
                            double n14 = n1 / n2;
                            Console.WriteLine("除法，结果为" + n14);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}