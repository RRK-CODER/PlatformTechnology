using System;

namespace Static_Polymorphism
{
    class Program
    {
        public class TestOverloading
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }
            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + a1 + a2);
            }
        }
        static void Main(string[] args)
        {
            TestOverloading obj = new TestOverloading();
            obj.Add("Lord ", "Ram");
            obj.Add(1, 10);
            Console.ReadLine();
        }
    }
}
