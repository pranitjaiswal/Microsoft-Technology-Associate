using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExample
{
    class Program
    {
        static void OutDemo(out int i)
        {
            i = 10;
        }
        static void Main(string[] args)
        {
            int num1;
            OutDemo(out num1);
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
