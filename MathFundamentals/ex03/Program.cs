using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Binary 1: ");
			string a = Console.ReadLine();
			Console.Write("Binary 2: ");
			string a1 = Console.ReadLine();
			foreach (char b in a)
			{
				if (b < '0' || b > '9')
				{
					Console.WriteLine("ERROR");
					return;
				}
			}
			foreach (char b in a1)
			{
				if (b < '0' || b > '9')
				{
					Console.WriteLine("ERROR");
					return;
				}
			}
			int c = Convert.ToInt32(a);
			int c1 = Convert.ToInt32(a1);

			int i = 0, rem = 0;
			int[] sumarray = new int[20];
			while (c != 0 || c1 != 0)
			{
				sumarray[i++] = (c % 10 + c1 % 10 + rem) % 2;
				rem = (c % 10 + c1 % 10 + rem) / 2;
				c = c / 10;
				c1 = c1 / 10;
			}
			if (rem != 0)
				sumarray[i++] = rem;
			--i;
			Console.WriteLine("Sum of the two binary numbers: ");
			while (i >= 0)
				Console.Write("{0}", sumarray[i--]);
			Console.ReadLine();
		}
	}
}
