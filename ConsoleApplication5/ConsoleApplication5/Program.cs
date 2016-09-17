using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            if(myIntArray.IsFixedSize)
                Console.WriteLine("Array size is fixed");
            else
                Console.WriteLine("Array is not fixed size");
                Console.ReadLine();
        }
    }
}
