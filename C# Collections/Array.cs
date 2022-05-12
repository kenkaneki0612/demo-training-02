using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
			//Array
			int[] evenNums = { 2, 4, 6, 8, 10 };

			for (int i = 0; i < evenNums.Length; i++)
				Console.WriteLine(evenNums[i]); 

			for (int i = 0; i < evenNums.Length; i++)
				evenNums[i] = evenNums[i] + 10; 

			Console.WriteLine("After setting values");

			for (int i = 0; i < evenNums.Length; i++)
				Console.WriteLine(evenNums[i]);
		}
    }
}
