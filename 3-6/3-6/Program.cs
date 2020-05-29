using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。
 * 每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
2. 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。*/
public class IlegalException : SystemException { }

namespace _3_6
{
    public abstract class Graph
    {   
        public abstract int Area();
        public abstract Boolean Legal();
    }
    public class Rectangle : Graph
    {   
        private int _long;
        private int _short;
        override public int Area()
        {
            return _long * _short;
        }
        override public Boolean Legal()
        {
            if (_long > 0 && _short > 0)
                return true;
            else return false;
        }
        public Rectangle(int _long,int  _short)
        {
            this._long = _long;
            this._short = _short;
        }
    }
    public class Square : Graph
    {
        private int _long;
        override public int Area()
        {
            return _long * _long;
        }
        override public Boolean Legal()
        {
            if (_long > 0)
                return true;
            else return false;
        }
        public Square(int _long)
        {
            this._long = _long;
        }
    }
    public class Triangle : Graph
    {
        private int _long;
        private int _high;
        override public int Area()
        {
            return _long * _high/2;
        }
        override public Boolean Legal()
        {
            if (_long > 0 && _high > 0)
                return true;
            else return false;
        }
        public Triangle(int _long,int _short)
        {
            this._long = _long;
            this._high = _short; 
        }
    }
    class Factory
    {
        Random random = new Random();
        public  Graph Create(int i)
        {

            if (i == 0)
                return new Rectangle(Convert.ToInt32(random.Next() % 9+1), Convert.ToInt32(random.Next() % 9+1));
            else if (i == 1)
                return new Square(Convert.ToInt32(random.Next() % 9+1));
            else if (i == 2)
                return new Triangle(Convert.ToInt32(random.Next() % 9+1), Convert.ToInt32(random.Next() % 9+1));
            else return null;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            Graph[] graphs = new Graph[10];
            int sum_area = 0;
            Factory factory = new Factory();
            for (int i = 0; i <= 9; i++)
            {
                int randomN = random.Next(3);
                graphs[i] = factory.Create(randomN);
                /*if (graphs[i].Legal() == false)
                    throw new IlegalException();*/
                sum_area += graphs[i].Area();
                string graphsType;
                if (randomN == 0)
                    graphsType = "Rectangle";
                else if (randomN == 1)
                    graphsType = "Square";
                else if (randomN == 2)
                    graphsType = "Triangle";
                else graphsType = "Erro";
                Console.WriteLine(graphsType+"  "+ graphs[i].Area());
            }
            Console.WriteLine(sum_area);
            Console.Read();
        }
    }
}