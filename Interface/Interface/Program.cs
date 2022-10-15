using System;

namespace Interface
{
    interface IInterface1
    {
        void Method1();
        void Method2();
    }
    interface IInterface2
    {
        void Method2();
    }
        class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from MyClass2");
        }
          
    }
    class MyClass2 : MyClass1,IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        void IInterface1.Method2()
        {
            Console.WriteLine("Method 2 from IInterface1");
        }
        void IInterface2.Method2()
        {
            Console.WriteLine("Method 2 from IInterface2");
        }
    }
    class Program
    { 
        static void Main(string [] args)
        {
            MyClass2 m2 = new MyClass2();
            IInterface1 i1 = new MyClass2();
            i1.Method2();
            IInterface2 i2 = new MyClass2();
            i2.Method2();

        }
            }
    

}
