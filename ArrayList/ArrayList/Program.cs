using System;
using System.Collections;
namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            mylist.Add("My");
            mylist.Add("name is");
            mylist.Add("Rohit Ranjan Kumar ");
            mylist.Add("I am in ");
            mylist.Add("2020-2024");
            mylist.Add("batch");
            mylist.RemoveAt(5);
            foreach (var item in mylist)
                Console.WriteLine(item);
        }
    }
}