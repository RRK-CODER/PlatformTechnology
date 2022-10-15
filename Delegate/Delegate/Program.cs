using System;

namespace Delegate
{
    delegate int MyDel(int x, int y);
    class Program
    {


        public static int Add(int x , int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            MyDel del = new MyDel(Add);
            int result = del(10, 30);
            Console.WriteLine(result);
            del = Multiply;
            result = del(10, 30);
            Console.WriteLine(result);
        }
    }
}
