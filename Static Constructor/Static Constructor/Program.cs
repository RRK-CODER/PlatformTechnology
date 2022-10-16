using System;

namespace Static_Constructor
{
    class User
    {
        //Static Constructor
        static User()
        {
            Console.WriteLine("I am a static constructor");
        }
        //Default Constructor
        public User()
        {
            Console.WriteLine("I am a default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            User user1 = new User();
            Console.WriteLine("\n Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
