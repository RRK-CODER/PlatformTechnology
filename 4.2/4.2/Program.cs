using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ath
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int age = checkage();
                Console.WriteLine(age);
                Console.ReadLine();
            }
            catch (cusage ex)
            {
                Console.WriteLine(ex.Message);

            }

            try
            {
                string name = checkname();
                Console.WriteLine(name);
                Console.ReadLine();
            }
            catch (cusage ex)
            {
                Console.WriteLine(ex.Message);


            }
            try
            {
                double mobileno = checkmobilno();
                Console.WriteLine(mobileno);
                Console.ReadLine();
            }
            catch (cusmobileno ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static int checkage()
        {

            Console.WriteLine("Enter the age of the customer :");
            int age = Convert.ToInt32(Console.ReadLine());


            if (age < 18)
            {
                throw new Exception("Age must be greater than 18");
            }
            return age;


        }

        static string checkname()
        {
            Console.WriteLine("Enter the name of the customer :");
            string name = Console.ReadLine();

            if (name.Any(char.IsDigit))
            {
                throw new Exception("Name should not contain number :");
            }
            return name;
        }
        static double checkmobilno()
        {
            int number = 0, count = 0;
            Console.WriteLine("Enter the mobile number of the customer :");
            double mobilno = Convert.ToDouble(Console.ReadLine());
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            if (count < 10 || count > 10)
            {
                throw new Exception("Mobile number should contain 10 digits");
            }
            return mobilno;


        }

    }

    public class cusage : Exception
    {
        public cusage(string msg) : base(msg)
        {
            Console.WriteLine("Exception occured");

        }
    }

    public class cusname : Exception
    {
        public cusname(string msg) : base(msg)
        {
            Console.WriteLine("Exception occured");
        }
    }

    public class cusmobileno : Exception
    {
        public cusmobileno(string msg) : base(msg)
        {
            Console.WriteLine("Exception occured");
        }

    }

}