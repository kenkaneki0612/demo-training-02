using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_24
{

    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Hello World!");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Hello!");
        }
    }

    class Interface
    {
        static void Main(string[] args)

        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("");

            file2.ReadFile();
            file2.WriteFile("");

        }
    }
}
