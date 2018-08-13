using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testingtesting2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj en eller fler av nedan produkter:");
                Console.WriteLine("");
                Console.WriteLine("ABC123");
                Console.WriteLine("laban");
                Console.WriteLine("exit");

                string menuSelection = Console.ReadLine();

                if (menuSelection == "abc123" || menuSelection == "ABC123")
                {
                    Console.WriteLine("=== WELCOME TO THE GAME! ===");
                }

                else if (menuSelection == "laban" || menuSelection == "LABAN")

                {
                    Console.WriteLine("=== HIGHSCORE ===");
                }
                else if (menuSelection == "exit" || menuSelection == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ogiltigt val!");
                }




            }
        }
    }
}

