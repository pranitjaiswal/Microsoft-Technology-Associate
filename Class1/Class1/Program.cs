using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program1
    {
        public void method1()
        {
        Console.WriteLine("This is the method from program1 class");
        }
    }

    class Program
    {
        public void method()
        {
            Console.WriteLine("This is the method from program class");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Program1 obj1=new Program1();
            obj.method();
            obj1.method1();
            Console.ReadLine();
        }
    }
}
