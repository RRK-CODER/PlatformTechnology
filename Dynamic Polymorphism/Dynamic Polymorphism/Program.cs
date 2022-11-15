using System;

namespace Dynamic_Polymorphism
{
    class Program
    {
        public class Base
        {
            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }
        public class Derived : Base
        {
            public override void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            Base objBase;
            objBase = new Base();
            objBase.Show();//    Output ----> Show From Base Class.  
            objBase = new Derived();
            objBase.Show();//Output--> Show From Derived Class.  
            Console.ReadLine();
        }
    }
}
