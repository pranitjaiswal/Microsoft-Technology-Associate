using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        public void add(ref int var)
        {
            var++;
        }     
        static void Main(string[] args)
        {
            Program obj = new Program();
            int number = 6;
            obj.add(ref number);
            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
