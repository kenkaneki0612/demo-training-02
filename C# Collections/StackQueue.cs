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
			//Stack
			Stack<int> numbers = new Stack<int>();
			numbers.Push(1);
			numbers.Push(2);
			numbers.Push(3);
			numbers.Push(4);

			foreach (var item in numbers)
				Console.Write(item + ",");

			//Queue
			Queue<int> callerIds = new Queue<int>();
			callerIds.Enqueue(1);
			callerIds.Enqueue(2);
			callerIds.Enqueue(3);
			callerIds.Enqueue(4);

			foreach (var id in callerIds)
				Console.WriteLine(id);
		}
    }
}
