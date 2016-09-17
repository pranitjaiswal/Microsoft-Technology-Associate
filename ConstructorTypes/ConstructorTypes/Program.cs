using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTypes
{
    class calc
    {
        public static int a, b;
        static calc()
        {
            a = 10;
            b = 20;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int result = calc.a+calc.b;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
