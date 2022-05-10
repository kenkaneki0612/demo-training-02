using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_12
{
    class Program
    {

		//Struct
		struct Coordinate
{
		public int x;
		public int y;
}
		//Enum 
		enum WeekDays
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

        public static void Main()
        {

			//Variable
			int i = 100;
			int j = i + 20;
			Console.WriteLine("j = {0}", j);

			i = 200;
			j = i + 20;
			Console.WriteLine("j = {0}", j);

			i = 300;
			Console.WriteLine("j = {0}", j);

			//Data Types
			int a = 100;
			uint u = (uint)a;
			Console.Write(a);

			//Numbers
			double d = 0.12e2;
			Console.WriteLine(d);

			//String
			string firstName = "James";
			string lastName = "Bond";
			string code = "007";
		
			string fullName = $"Mr. {firstName} {lastName}, Code: {code}";
		
			Console.WriteLine(fullName);

			//Datetime
			var str = "5/12/2020";
			DateTime dt;
		
			var isValidDate = DateTime.TryParse(str, out dt);
			if (isValidDate)
				Console.WriteLine(dt);
			else
				Console.WriteLine($"{str} is not a valid date string");
			
			//Struct
			Coordinate point = new Coordinate();
		
			Console.WriteLine(point.x); 
			Console.WriteLine(point.y); 

			//Enum
			Console.WriteLine(WeekDays.Friday);
			int day = (int) WeekDays.Friday;
			Console.WriteLine(day);
		
			var wd = (WeekDays)5;
			Console.WriteLine(wd);
		}
	}
}
