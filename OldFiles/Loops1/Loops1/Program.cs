using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool shouldRun = true;
            //while (shouldRun)
            //{
            //    Console.WriteLine("I loopen - loopa igen?");
            //    string input = Console.ReadLine();

            //    if (input != "y")

            //        shouldRun = false;

            //}

            //do
            //{
            //    Console.WriteLine("I loopen - loopa igen?");
            //} while (Console.ReadLine() == "y");

            //for (int i = 0; i < 3; i++) //praxis att döpa int till "i" men man kan döpa den till x eller y om man hellre vill det.
            //{
              //  Console.WriteLine(i);
            //}
            for (int x =0; x < 8; x++)
            {
                for (int y = 0; y < 4; y++)
                    Console.WriteLine(x + " " + y);
            }

        }
    }
}
