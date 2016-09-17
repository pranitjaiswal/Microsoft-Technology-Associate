using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidQuestion
{
    class Program
    {
        static void Main(string[] args)
        {           
            int sum = 0;
            int[] array = new int[10];
            Console.WriteLine("Enter the numbers to be added :");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 10; j++)
            {
                sum = sum + array[j];
            }
            Console.WriteLine("The sum of numbers is :");          
        }
    }
}
