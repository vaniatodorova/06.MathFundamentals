using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Число(10): ");
			string a = Console.ReadLine();
			foreach (char b in a)
			{
				if (b < '0' || b > '9')
				{
					Console.WriteLine("ERROR");
					return;
				}
			}
			int c = Convert.ToInt32(a);
			int i;
			int[] Array = new int[10];
			for (i = 0; c > 0; i++)
			{
				Array[i] = c % 2;
				c = c / 2;
			}
			Console.Write("Числото(2): ");
			for (i = i - 1; i >= 0; i--)
			{
				Console.Write(Array[i]);
			}
			Console.WriteLine();
		}
	}
}
