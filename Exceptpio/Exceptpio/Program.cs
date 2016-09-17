using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptpio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter 2 numbers : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero. Enter value greater than one");
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a number and not a string ");
            }
            finally
                {
                    Console.WriteLine("finally exe");
                }
            Console.ReadLine();
        }
    }
}
