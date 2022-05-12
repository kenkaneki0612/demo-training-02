using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoops
{
    class Example
    {
        static void Main(string[] args)
        {
			//if Statement
			int i = 10, j = 20;

			if (i > j)
			{
				Console.WriteLine("i is greater than j");
			}

			if (i < j)
			{
				Console.WriteLine("i is less than j");
			}

			if (i == j)
			{
				Console.WriteLine("i is equal to j");
			}

			//Ternary Operator ?:
			int x = 10, y = 100;

			string result = x > y ? "x is greater than y"
									: x < y ? "x is less than y"
										: x == y ? "x is equal to y" : "No result";

			Console.WriteLine(result);

			//Switch Statement
			string statementType = "switch";

			switch (statementType)
			{
				case "if.else":
					Console.WriteLine("if...else statement");
					break;
				case "ternary":
					Console.WriteLine("Ternary operator");
					break;
				case "switch":
					Console.WriteLine("switch statement");
					break;
			}

		}
	}
}
