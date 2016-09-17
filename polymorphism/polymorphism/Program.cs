using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class calculate
    {
        public int Max(int number1, int number2)
             {
                 if((number1)>(number2))
                     return(number1);
                 
                 else 
                     return(number2);
                 
             }

        public float Max(float number1, float number2)
           {
                if((number1)>(number2))
                     return(number1);

                else 
                     return(number2);
                 
           }
    }
    class Program
    {  
        
        static void Main(string[] args)
        {
            calculate c1 = new calculate();
            Console.WriteLine(c1.Max(12, 13));
            Console.WriteLine(c1.Max(11.2F, 13.4F));
            Console.ReadLine();
        }
    }
}
