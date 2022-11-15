using System;

namespace Delegate
{
    delegate void MyDel(int x, int y);
    class Program
    {
        public static void Add(int x , int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main(string[] args)
        {
            MyDel del = Add;
            del += Multiply;
            del(10, 30);
           
        }
    }
}
