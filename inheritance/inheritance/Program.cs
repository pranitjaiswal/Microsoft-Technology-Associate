using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Square
    {   public int Squarevar = 20;
         public void Method1()
         {
             Console.WriteLine("This is my sqare class method");
         }
         public void Draw()
         {
             Console.WriteLine("This is my draw class");
         }
    }

    public class Triangle:Square
    {
        public int Trianglevar = 40;
        public void Method2()
        {
            Console.WriteLine("This is my triangle class method");
            Triangle obj1 = new Triangle();
            obj1.Draw();

        }

    }

     public class Polygon:Triangle
    {
        public int Polygonvar = 50;
        public void Method3()
        {
            Console.WriteLine("This is my polygon class method");
            Polygon obj = new Polygon();
            obj.Draw();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Polygon obj = new Polygon();
            obj.Method3();
        }
    }
}
