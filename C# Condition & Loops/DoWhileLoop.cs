using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoops
{
    class Program
    {
        static void Main(string[] args)
        {

			//Do While Loop
			int i = 0;

			do
			{
				Console.WriteLine("i = {0}", i);
				int j = i;

				i++;

				do
				{
					Console.WriteLine("j = {0}", j);
					j++;

				} while (j < 2);

			} while (i < 2);

		}
	}
}
