using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_24
{
    //Static Class
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }

    //Object Initializer Syntax
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }

    class Example
    {
        static void Main(string[] args)

        {
            //Operator
            int a = 5 + 3 * 3;
            int b = 5 + 3 * 3 / 2;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            //Run Static Class
            var result = Calculator.Sum(10, 25); 
            Calculator.Store(result);
            Console.WriteLine(result);

            var calcType = Calculator.Type; 
            Calculator.Type = "Scientific";

            //Run Object Initializer Syntax
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };

            Console.WriteLine(std.StudentName);


        }
    }
}
