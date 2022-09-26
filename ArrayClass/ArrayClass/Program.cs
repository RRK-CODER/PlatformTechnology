using System;

namespace Arrayclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            Console.Write("Length of the array: ");
            Console.Write(" " + a.Length);
            Console.WriteLine();
            Console.WriteLine("Given array");
            foreach (int item in a)
                Console.Write(" " + item);
        }
    }
}