using System;

namespace Arrayclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 29, 23, 24 , 27 , 4};
            Console.Write("The length of the given array is  ");
            Console.Write(" " + a.Length);
            Console.WriteLine();
            Console.WriteLine("Given array");
            foreach (int item in a)
                Console.Write(" " + item);
        }
    }
}