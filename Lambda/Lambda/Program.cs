using System;

namespace Lambda
{
    delegate int Del(int x);
        class Program
    {
        static void Main(string[] args)
        {
            Del del = x => x * x;
            int Result = del(4);
            Console.WriteLine(Result);
        }
    }
}
