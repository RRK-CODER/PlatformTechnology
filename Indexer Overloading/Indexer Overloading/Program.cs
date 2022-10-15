using System;

namespace Indexer_Overloading
{
    class Program
    {
        private string[] word = new string[2];

        // this indexer gets executed
        // when Obj[0]gets executed
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
        // this is an Overloaded indexer
        // which will execute when 
        // Obj[1.0f] gets executed
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

            Obj[0] = "Lord "; // Value of word[0]
            Obj[1.0f] = "Ram"; // Value of word[1]
            Console.WriteLine(Obj[0] + Obj[1.0f]);
        }
    }
}
