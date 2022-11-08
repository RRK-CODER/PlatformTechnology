// C# program to illustrate the use of Delegates

using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._1
{

    class delidemo
    {
        List<String> l1 = new List<string>();
        List<int> l2 = new List<int>();

        public delegate void dele1();




        public void rollno_name()
        {



            l1.Add("Priya");
            l1.Add("Rohit");
            l1.Add("Nisha");
            l1.Add("Mohit");

            Console.WriteLine("Name of Students");

            foreach (String i in l1)
            {
                Console.WriteLine(i);
            }



            l2.Add(97);
            l2.Add(92);
            l2.Add(88);
            l2.Add(83);
            Console.WriteLine();
            Console.WriteLine("Marks obtained by Students");
            Console.WriteLine();

            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }
        }


        public void sort_name()
        {
            Console.WriteLine();

            l1.Sort();
            Console.WriteLine("Name of Students in ascending order");
            Console.WriteLine();

            foreach (String i in l1)
            {
                Console.WriteLine(i);
            }
        }

        public void high_marks()
        {
            Console.WriteLine();
            Console.WriteLine("Highest marks obtained is " + l2.Max());

        }

        public static void Main(String[] args)
        {

            delidemo obj = new delidemo();


            dele1 del_obj1 = new dele1(obj.rollno_name);

            del_obj1 += obj.sort_name;
            del_obj1 += obj.high_marks;


            del_obj1();

        }
    }
}
