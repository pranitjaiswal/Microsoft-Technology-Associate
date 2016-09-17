using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    abstract class calculate
    {
        public abstract void cal(int x, int y);
    }
    class sum : calculate
    {
        public override void cal(int x, int y)
        {
            int a;           
            a = x + y;
            Console.WriteLine("sum is " + a);
        }
    }
    class diff : calculate
    {

        public override void cal(int x, int y)
        {
            int b;
            b = x - y;
            Console.WriteLine("difference = " + b);
        }
    }
    class mult : calculate
    {

        public override void cal(int x, int y)
        {
            int z;
            
            z = x * y;
            Console.WriteLine("product= " + z);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            sum s = new sum();
            s.cal(x, y);
            diff d = new diff();
            d.cal(x, y);
            mult m = new mult();
            m.cal(x, y);
            Console.ReadLine();
        }

    }
}