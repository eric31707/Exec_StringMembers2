using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string name = "aLLeN kUO";
			//Console.WriteLine(name.ToLower());
			Console.WriteLine("請輸入英文全名");
			string input = Console.ReadLine();
			string[]words=input.ToLower().Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
			}
			string result=string.Join(" ", words);
			Console.WriteLine(result);

		}
	}
}
