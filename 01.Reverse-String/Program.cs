using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var stack = new Stack<char>();
			foreach (var ch in input)
			{
				stack.Push(ch);
			}
			while (stack.Count != 0)
			{
				Console.Write(stack.Pop());
			}
			Console.WriteLine();
		}
	}
}