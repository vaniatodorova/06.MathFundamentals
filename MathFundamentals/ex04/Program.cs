using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Number(2): ");
			string a = Console.ReadLine();
			foreach (char b in a)
			{
				if (b < '0' || b > '1')
				{
					Console.WriteLine("ERROR");
					return;
				}
			}
			int binaryValue = Convert.ToInt32(a);
			int decimalValue = 0;
			int base1 = 1;
			while (binaryValue > 0)
			{
				int reminder = binaryValue % 10;
				binaryValue = binaryValue / 10;
				decimalValue += reminder * base1;
				base1 = base1 * 2;
			}
			Console.WriteLine("Number(10): {0}", decimalValue);
		}
	}
}
