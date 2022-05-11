using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_24
{

    public class Student
    {

        public string StudentName { get; set; }

    }
    class ValueTypeReferenceType
    {
        //Value Type
        static void ChangeValue(int x)
        {
            x = 100;

            Console.WriteLine(x);
        }

        //Reference Type
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
        static void Main(string[] args)

        {
            //Run Value Type 
            int i = 200;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);

            //Run Reference Type
            Student std1 = new Student();

            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
    }
}
