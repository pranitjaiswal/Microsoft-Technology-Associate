using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    public class calc
    {
        public double addnumber(int num1, double num2)
        {
            double result;
            result = num1 + num2;
            return (result);
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            calc obj = new calc();
            double result1 = obj.addnumber(20, 10.4);
            Console.WriteLine(result1);
        }
    }
}
