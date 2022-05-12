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
			//Add Dictionary in Hashtable
			Dictionary<int, string> dict = new Dictionary<int, string>();

			dict.Add(1, "one");
			dict.Add(2, "two");
			dict.Add(3, "three");

			Hashtable ht = new Hashtable(dict);

			Console.WriteLine("Total elements: {0}", ht.Count);
		}
    }
}
