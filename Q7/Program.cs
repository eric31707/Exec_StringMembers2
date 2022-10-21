using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入要計算小數");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}
			Console.WriteLine("請輸入要計算小數");
			string input1 = Console.ReadLine();
			if (string.IsNullOrEmpty(input1))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}
			double result = (Convert.ToDouble(input)) + (Convert.ToDouble(input1));
			Console.WriteLine("兩個小數總合為" + Math.Round(result, 2, MidpointRounding.AwayFromZero));
		}
	}
}
