using System;

namespace Indexer_Overloading
{
    class Program
    {
        private string[] word = new string[2];

        public string this[int flag]
        {
            get
            {
                string temp = word[flag];
                return temp;
            }
            set
            {
                word[flag] = value;
            }

        }
        public string this [float flag]
        {
            get
            {
                string temp = word[1];
                return temp;
            }
            set
            {
                word[1] = value;
            }
        }
        static void Main(string[] args)
        {
            Program Obj = new Program();

            Obj[0] = "Lord";
            Obj[1.0f] = "Ram";
            Console.WriteLine(Obj[0] + Obj[1.0f]);
        }
    }
}
