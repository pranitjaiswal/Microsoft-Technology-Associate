using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_agency
{
    class travel
    {
        public void menu()
        {
            int x;
            travel obj1 = new travel();
            Console.WriteLine("Welcome to Sneha Thomas Travelling Agency");
            Console.WriteLine("List of places to vist");
            Console.WriteLine("1. Mumbai to Switzerland (7 days and 8 nights) - Rs. 8 Lakh");
            Console.WriteLine("2. Mumbai to Thailand (9 days and 10 nights) - Rs. 5 Lakh");
            Console.WriteLine("3. Mumbai to Pakistan (5 days and 6 nights) - Rs. 2 Lakh");
            Console.WriteLine("Enter the option you want to choose : ");
            x = Convert.ToInt32(Console.ReadLine());
            obj1.bookingcost(x);
        }

        public void bookingcost(int a)
        {    
            double bc,payment,pending;
            switch (a)
            {
                case 1:
                    {
                        bc = 0.1 * 800000;
                        Console.WriteLine("The amount to be paid in advance is : " + bc);
                        Console.WriteLine("Enter the amount you wish to pay : ");
                        payment = Convert.ToDouble(Console.ReadLine());
                        pending = 800000 - payment;
                        Console.WriteLine("Your remaining amount is : ", +pending);
                        break;
                    }
                case 2:
                    {
                        bc = 0.1 * 500000;
                        Console.WriteLine("The amount to be paid in advance is : " + bc);
                        Console.WriteLine("Enter the amount you wish to pay : ");
                        payment = Convert.ToDouble(Console.ReadLine());
                        pending = 500000 - payment;

                        Console.WriteLine("Your remaining amount is : " +pending);
                        break;
                    }
                case 3:
                    {
                        bc = 0.1 * 200000;
                        Console.WriteLine("The amount to be paid in advance is : " + bc);
                        Console.WriteLine("Enter the amount you wish to pay : ");
                        payment = Convert.ToDouble(Console.ReadLine());
                        pending = 200000 - payment;
                        Console.WriteLine("Your remaining amount is : " +pending);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid entry ");
                        break;
                    }
              }
            Console.WriteLine("Do you want to continue and book more tickets");
            string yn = Console.ReadLine();
            switch (yn)
            {
                case "yes":
                    {
                        travel obj = new travel();
                        obj.menu();
                        break;
                    }
                case "no":
                    {
                        Console.WriteLine("Buhbye guys");
                        Console.ReadLine();
                        break;
                    }
            }

     }
}
  
            class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            travel obj = new travel();
            obj.menu();
            Console.ReadLine();
        }
    }
}
