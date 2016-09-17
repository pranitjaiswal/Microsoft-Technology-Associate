using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Animal
    {
        public virtual void foodhabit()
        {
            Console.WriteLine("Animal has different food habits");
        }

    }

    class CarniAnimal : Animal
    {
        public override void foodhabit()
        {
            //base.foodhabit();
            Console.WriteLine("CarniAnimal");
        }
    }
    class HerbiAnimal : Animal
    {
        public override void foodhabit()
        {
            //base.foodhabit();
            Console.WriteLine("HerbiAnimal");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarniAnimal cr = new CarniAnimal();
            cr.foodhabit();
            HerbiAnimal hr = new HerbiAnimal();
            hr.foodhabit();
            Console.ReadLine();
        }
    }
}
