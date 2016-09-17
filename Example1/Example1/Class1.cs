using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no.s");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = a * b;
            Console.WriteLine("Total is " + ans);
            Console.ReadLine();

        }
    }
}
