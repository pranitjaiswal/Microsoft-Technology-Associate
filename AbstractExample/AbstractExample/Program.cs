using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    abstract class Animal
    {
        public abstract void FoodHabits();
    }

    class HerbAnimal:Animal
    {

        public override void FoodHabits()
        {
            Console.WriteLine("this is my herbi method");
        }
    }
    class CarniAnimal : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("this is my carni method");
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HerbAnimal a = new HerbAnimal();
            a.FoodHabits();
            CarniAnimal b = new CarniAnimal();
            b.FoodHabits();
            Console.ReadLine();
        }
    }
}
