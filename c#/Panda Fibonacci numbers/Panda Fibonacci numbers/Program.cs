using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 2;
            decimal b = 3;



            for (int i = 0; i < 50; i++)
            {
 
                var c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);

                //Console.WriteLine(a);
                //Console.WriteLine(b);
                //a += b;
                //b += a;

            }
        }
    }
}
