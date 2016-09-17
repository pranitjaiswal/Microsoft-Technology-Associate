using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class calculate
    {
        int sum = 0;
        int count =0;
        float avg;

        public void DoAVG()
        {
            if (count == 0)
            {
                throw (new CountIsZeroException(""));
            }
            avg = sum / count;
            Console.WriteLine(avg);
        }
    }

    public class CountIsZeroException : ApplicationException
    {
        public CountIsZeroException(string message):base (message)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            calculate c1 = new calculate();
            try
            {
                c1.DoAVG();
            }
            catch (CountIsZeroException ex)
            {
                Console.WriteLine("CountIsZeroException Class Raised: Cannot Divide by 0");
            }
                Console.ReadLine();
        }
    }
}
