using System;
using System.Collections;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Threading;

namespace _4._3_Library_Details_Using_multithreading
{
    class library
    {
        public ArrayList bks;
        public string Searchedbook, lend;
        public void th2()
        {
            ArrayList bks = new ArrayList();
            bks.Add("The Psyschology of Money");
            bks.Add("My Experience with truth -Mahatma Gandhi");
            bks.Add("Chanakya Neeti");
            bks.Add("Bhagvad Geeta");
            bks.Add("Shree Ramcharitramanas");
            foreach (object obj in bks)
            {
                Console.WriteLine(" {0} ", obj);
            }
        }
        public void th1()
        {
            ArrayList bks = new ArrayList();
            bks.Add("The Psyschology of Money");
            bks.Add("My Experience with truth -Mahatma Gandhi");
            bks.Add("Chanakya Neeti");
            bks.Add("Bhagvad Geeta");
            bks.Add("Shree Ramcharitramanas");
            Console.WriteLine("Enter the book name :");
            Searchedbook = Console.ReadLine();
            for (int i = 0; i < bks.Count; i++)
            {
                if (bks[i].Equals(Searchedbook))
                {
                    Console.WriteLine("Available");


                }

            }
            Console.ReadLine();


        }

        public void th3()
        {
            ArrayList bks = new ArrayList();
            bks.Add("The Psyschology of Money");
            bks.Add("My Experience with truth -Mahatma Gandhi");
            bks.Add("Chanakya Neeti");
            bks.Add("Bhagvad Geeta");
            bks.Add("Shree Ramcharitramanas");
            Console.WriteLine("ENTER THE BOOK WHICH YOU WANT TO LEND  : ");
            lend = Console.ReadLine();
            bks.Remove(lend);
            Console.WriteLine("THE LIST AFTER LENDING BOOK ");
            foreach (object obj in bks)
            {
                Console.WriteLine(" {0} ", obj);
            }
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            library lb = new library();
            Thread thr2 = new Thread(new ThreadStart(lb.th2));
            thr2.Start();
            Thread thr1 = new Thread(new ThreadStart(lb.th1));
            thr1.Start();

            Thread thr3 = new Thread(new ThreadStart(lb.th3));
            thr3.Start();

        }
    }
}