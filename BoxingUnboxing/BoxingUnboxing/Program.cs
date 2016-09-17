using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            object obj = x;//Boxing
            int y = (int)obj;//Unboxing
        }
    }
}
