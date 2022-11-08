using System;

namespace _3._4
{

	class rect
	{

		public int number1, ar;
		bool t;
		public rect(int num1, int num2)
		{
			number1 = num1 * num2;
			this.ar = number1;
			this.t = false;
		}


		public static bool operator >(rect c1, rect c2)
		{
			rect c3 = c1;
			rect c4 = c2;
			c3.t = (c3.ar > c4.ar);
			if (c3.t == true)
				return true;
			else
				return false;
		}
		public static bool operator <(rect c1, rect c2)
		{
			rect c3 = c1;
			rect c4 = c2;
			c3.t = (c1.ar < c2.ar);
			if (c3.t == true)
				return true;
			else
				return false;
		}


	}

	class EntryPoint
	{
		static void Main(String[] args)
		{

			rect rec1 = new rect(5, 2);
			rect rec2 = new rect(7, 8);
			if (rec1 > rec2)
				Console.WriteLine("Rec1 is greater");
			else if (rec1 < rec2)
				Console.WriteLine("Rec2 is greater");

		}
	}
}

