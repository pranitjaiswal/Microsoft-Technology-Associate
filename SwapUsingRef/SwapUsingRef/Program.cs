using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapUsingRef
{
    class Program
    {
        static void SwapRef(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter no1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no2");
            b = Convert.ToInt32(Console.ReadLine());
            SwapRef(ref a,ref b);
            Console.WriteLine("the swapped nos are:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
