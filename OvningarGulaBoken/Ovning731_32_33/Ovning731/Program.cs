using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning731
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder idag? j/n");
            string input = Console.ReadLine();
            if (input == "j")
                Console.WriteLine("Vi går på picknick!");
            else if (input == "n")
                Console.WriteLine("Vi stannar inne och läser en bok");
            else
                Console.WriteLine("Jag förstår inte");


        }
    }
}
