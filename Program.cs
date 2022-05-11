using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_24
{
    class Program
    {
        static void Main(string[] args)

        {
            //StringBuilder
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("Free-training-02.\n");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);

            //Anonymous Type
            var student = new { FirstName = "Ken", id = 2, LastName = "Kaneki" };
            Console.WriteLine(student.GetType().ToString());

            //Dynamic Types
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello Free training 02!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
        }
    }
}
