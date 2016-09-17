using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAccessSpecifiers
{
    class car
    {

        void hock()
        {
            Console.WriteLine("Honking");
        }
        public void SetModel()
        {
            Console.WriteLine("Enter the model number : ");
            string Model = Console.ReadLine();
        }
        public void DisplayModel()
        {
            Console.WriteLine("The Model is : ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            car ford=new car();
            ford.SetModel();
            ford.DisplayModel();
            ford.hock(); //Error as it is private. So, can't be accessed.
            Console.ReadLine();
        }
    }
}
