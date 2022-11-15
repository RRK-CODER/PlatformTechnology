using System;

namespace Sealed_Class
{
    class Program
    {
      sealed class MyClass1
        {
            public void SampleMethod()
            {
                Console.WriteLine("Sample Method in MyClass1");
            }
        }
        class MyClass2: MyClass1
        {
           
        }
        class Program
        {
            static void Main(string [] args)
            {

            }
        }
    }
}
// It will show error, cannot derive from sealed class