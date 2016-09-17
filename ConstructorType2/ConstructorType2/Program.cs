using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorType2
{
    public class cal
    {
        public int x, y;
        public cal(int num1, int num2)
        {
            x = num1;
            y = num2;
        }
        ~cal()
        {
            Console.WriteLine("Destructor invoked");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            int num1,num2;
            Console.WriteLine("enter no1,no2");
            num1= Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            cal obj=new cal(num1,num2);
            int ans = obj.x + obj.y;
            
            Console.ReadLine();
        }
    }
}
