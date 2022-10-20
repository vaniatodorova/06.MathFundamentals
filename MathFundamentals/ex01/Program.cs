using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("25 to binary {0}.", Convert.ToString(25, 2));
			Console.WriteLine("137 to binary {0}.", Convert.ToString(137, 2));
			int deci = 86;
			Console.WriteLine("{0} to hexadecimal is {1}.",deci, deci.ToString("X"));
			int deci2 = 189;
			Console.WriteLine("{0} to hexadecimal is {1}.",deci2, deci2.ToString("X"));
			Console.WriteLine("24 to octal {0}.", Convert.ToString(24, 8));
			Console.WriteLine("81 to octal {0}.", Convert.ToString(81, 8));
			string binary = "1100101";
			Console.WriteLine("{0} to decimal is {1}.", binary, Convert.ToInt64(binary, 2));
			string binary2 = "11000";
			Console.WriteLine("{0} to decimal is {1}.", binary2, Convert.ToInt64(binary2, 2));
			string hexa = "125";
			Console.WriteLine("{0} to decimal is {1}.",hexa, Convert.ToInt32(hexa, 16));
			string hexa2 = "1A1";
			Console.WriteLine("{0} to decimal is {1}.", hexa2, Convert.ToInt32(hexa2, 16));
			string octal = "1017";
			Console.WriteLine("{0} to decimal is {1}.", octal, Convert.ToInt64(octal, 8));
			string octal2 = "121";
			Console.WriteLine("{0} to decimal is {1}.", octal2, Convert.ToInt64(octal2, 8));
		}
	}
}
