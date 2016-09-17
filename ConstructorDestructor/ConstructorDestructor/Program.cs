using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructor
{
    class calc
    {
        static int num1, num2, ans;
        public calc()
        {
            num1 = 10;
            num2 = 20;
        }
        /*public void Initialise()
        {
            num1 = 10;
            num2 = 20;
        }*/
        public void addnum()
        {
            ans = num1 + num2;
        }
        public void Display()
        {
            Console.WriteLine("the total is:" + ans);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calc c1 = new calc();
            //c1.Initialise();
            c1.addnum();
            c1.Display();
            Console.ReadLine();
        }
    }
}
