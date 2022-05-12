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
			//ValueTuple
			(int Id, string FirstName, string LastName) person = (1, "Free", "Training");
			Console.WriteLine(person.Id); 
			Console.WriteLine(person.FirstName); 
			Console.WriteLine(person.LastName); 
		}
    }
}
