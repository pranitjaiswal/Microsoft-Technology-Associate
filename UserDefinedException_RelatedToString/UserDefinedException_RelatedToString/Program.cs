using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException_RelatedToString
{
    class ExceptionHandling
    {
        int a;
        public void input()
        {
            
            Console.WriteLine("Enter a number : ");
            if (a >=65 || a<=95 ||a>=97 ||a<=122)
            a = Convert.ToInt32(Console.ReadLine());
            else 
                throw

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling obj = new ExceptionHandling();
            obj.input();
            Console.ReadLine( );
        }
    }
}
