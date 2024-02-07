using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
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
