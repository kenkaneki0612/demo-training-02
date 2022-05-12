using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
			//Tuples
			var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
			Console.WriteLine(numbers.Item1); // returns 1
			Console.WriteLine(numbers.Item7); // returns 7
			Console.WriteLine(numbers.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
			Console.WriteLine(numbers.Rest.Item1.Item1); //returns 8
			Console.WriteLine(numbers.Rest.Item1.Item2); //returns 9
		}
    }
}
