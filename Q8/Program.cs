using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入電話號碼");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input)||input.Length!=10)
			{
				Console.WriteLine("你輸入的電話號碼有誤");
				return;
			}
			string phonenumber=input.Substring(0,4)+new string('*',4)+input.Substring(8,2);
			Console.WriteLine(phonenumber);
		}
	}
}
