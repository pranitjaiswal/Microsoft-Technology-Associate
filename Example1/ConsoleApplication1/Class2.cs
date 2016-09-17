using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class2
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            int age;
            Console.WriteLine("Enter the Name :");
            name=Console.Readline();
            Console.WriteLine("Enter the City :");
            city=Console.Readline();
            Console.WriteLine("Enter the Age :");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} aged {1} lives in {2}", name, age, city);
            Console.ReadLine();
        }
    }
}
