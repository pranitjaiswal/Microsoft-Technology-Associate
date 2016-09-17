using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray=new int[4][];
            jaggedArray[0] = new int[2] { 7, 9 };
            jaggedArray[1] = new int[4] {1,4,6,9};
            jaggedArray[2] = new int[6] {11,12,15,18,90,76};
            jaggedArray[3] = new int[3] { 3,5,1};

            for(int i=0;i<jaggedArray.Length;i++)
            {
                Console.Write("Element({0}) :",i+1);
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.Write(jaggedArray[i][j] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
