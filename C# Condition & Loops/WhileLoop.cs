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

			int i = 0, j = 1;

			while (i < 2)
			{
				Console.WriteLine("i = {0}", i);
				i++;

				while (j < 2)
				{
					Console.WriteLine("j = {0}", j);
					j++;
				}
			}

		}
	}
}
