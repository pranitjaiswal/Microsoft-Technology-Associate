using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            bool equal= calculate.AreEqual<int>(12,1);
            bool equal1 = calculate.AreEqual<string>("ab", "ab");
            if(equal)
            { 
                Console.WriteLine("equal");
            }
            else
                Console.WriteLine("not equal");

            if (equal1)
            {
                Console.WriteLine("equal");
            }

            else
                Console.WriteLine("not equal");

            Console.ReadLine();
        
        }
    }
    public class calculate
    {
       /* public static bool AreEqual(object value1, object value2) (boxing unboxing unneccesarily done)
        {
            return value1 == value2;
        }*/
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
