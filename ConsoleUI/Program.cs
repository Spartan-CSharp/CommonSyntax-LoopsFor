using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a comma-separated list of first names (no spaces): ");
			string firstnamelist = Console.ReadLine();
			string[] firstnames = firstnamelist.Split(',');

			for ( int i = 0; i < firstnames.Length; i++ )
			{
				Console.WriteLine($"Hello {firstnames[i]}!");
			}

			_ = Console.ReadLine();
		}
	}
}
