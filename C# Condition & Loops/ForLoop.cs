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

			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
					break;

				Console.WriteLine("Value of i: {0}", i);
			}
		}
	}
}
