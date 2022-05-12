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
			//Access Dictionary Elements
			var cities = new Dictionary<string, string>(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

			Console.WriteLine(cities["UK"]); 
			Console.WriteLine(cities["USA"]);
											 

			
			if (cities.ContainsKey("France"))
			{
				Console.WriteLine(cities["France"]);
			}

			
			string result;

			if (cities.TryGetValue("France", out result))
			{
				Console.WriteLine(result);
			}

			Console.WriteLine("---access elements using for loop---");
			
			for (int i = 0; i < cities.Count; i++)
			{
				Console.WriteLine("Key: {0}, Value: {1}",
														cities.ElementAt(i).Key,
														cities.ElementAt(i).Value);
			}
		}
    }
}
