using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class hospitalms
    {
        public void menu()
        {
        Console.WriteLine("Welcome to Sneha Thomas Hospital");
        Console.WriteLine("Choose one of the following options");
        Console.WriteLine("1. Book appointment");
        Console.WriteLine("2. Blood test");
        Console.WriteLine("3. Cardiologists");
        Console.WriteLine("4. CT scan");
        Console.WriteLine("5. Surgery");
        Console.WriteLine("6. Exit");
        int a;
        Console.WriteLine("Enter your choice : ");
        a=Convert.ToInt32(Console.ReadLine());
        hospitalms obj=new hospitalms();
        
            switch(a)
            {
                case 1:
                    obj.typesofdoctors();
                    break;
                case 2:
                    obj.bloodtest();
                    break;
                case 3:
                    obj.cardiologists();
                    break;
                case 4:
                    obj.ctscan();
                    break;
                case 5:
                    obj.surgery();
                    break;
                case 6:
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Enter from choices 1 to 6 ");
                    break;
            }

        }

        public void bookappointment(int x)
        {
            Console.WriteLine(");
        }

        public void typesofdoctors()
        {
            Console.WriteLine("Select the type of doctor you want from the following list");
            Console.WriteLine("1. Dentist");
            Console.WriteLine("2. Veternary");
            Console.WriteLine("3. Gynac");
            Console.WriteLine("4. Bone Specialists");
            Console.WriteLine("5. Pediatrician");
            int x=Convert.ToInt32(Console.ReadLine());
            hospitalms objtod=new hospitalms();
            objtod.dentist();
        }

        public void dentist()
        {
            Console.WriteLine("Choose from the following :");
            Console.WriteLine("1. Dr. Raphi");
            Console.WriteLine("2. Dr. Fernandes");
            Console.WriteLine("3. Dr. Fegade");
            Console.WriteLine("4. Dr. Jaiswal");
            Console.WriteLine("5. Dr. Panicker");
            int d=Convert.ToInt32(Console.ReadLine());
        }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
