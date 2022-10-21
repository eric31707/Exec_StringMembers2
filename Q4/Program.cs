using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入民國年月日");
			string input = Console.ReadLine();	
			if (string.IsNullOrEmpty(input) || input.Length != 7)
			{
				Console.WriteLine("請正確的民國年月日");
				return;
			}
			string Chyear = input.Substring(0, 3);
			string month = input.Substring(3, 2);
			string day = input.Substring(5, 2);
			int year = Convert.ToInt32(Chyear);
			int result = year + 1911;
			Console.WriteLine($"{result}/{month}/{day}");
		}
	}
}
