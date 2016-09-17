using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] EmpName=new string[5];
            int[] EmpAge=new int[5];
            string[] EmpGender=new string[5];
            string[] EmpBG=new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the name of Employee");
                EmpName[i] = Console.ReadLine();
                Console.WriteLine("Enter the age of Employee");
                EmpAge[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the gender of Employee");
                EmpGender[i] = Console.ReadLine();
                Console.WriteLine("Enter the blood group of Employee");
                EmpBG[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Employee details : {0} \t {1} \t {2} \t {3}", EmpName[i], EmpAge[i], EmpGender[i], EmpBG[i]);
            }
            Console.ReadLine();
         }
    }
}
