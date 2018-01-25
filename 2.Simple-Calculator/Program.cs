using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var input =  Console.ReadLine ();
            var elements = input.Split(' ');
            var stack = new Stack<string>();

            for (int counter = elements.Length - 1; counter >= 0; counter--)
            {
                stack.Push(elements[counter]);
            }

            while (stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var rightOperand = int.Parse(stack.Pop());
                switch (operand)
                {
                    case "+":
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
					case "-":
						stack.Push((leftOperand - rightOperand).ToString());
						break;
                }

            }

	        Console.WriteLine(stack.Pop());
        }
    }
}
