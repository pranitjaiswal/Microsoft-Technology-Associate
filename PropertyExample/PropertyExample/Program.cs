using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student2 c2 = new Student2();
            c2.SetId(101);
            c2.SetName("ABC");*/
            GetSetClass1 c3 = new GetSetClass1();
            c3.Id = 101;
            c3.name = "Abcd";
            Console.WriteLine("The Id is {0} Name is {1} Pass mark is {2}", c3.Id,c3.name,c3.PassMark );


            /*Student1 c1 = new Student1();
            c1.id = 101;
            c1.name = null;
            c1.passmark = 40;
            Console.WriteLine("Id is : {0} Name is {1} passmark {2}",c1.id,c1.name,c1.passmark );*/
            Console.ReadLine();
        }
    }
}
