using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterNamesInList();

        }
        static void EnterNamesInList()
        {
            Console.WriteLine("Enter names in a list: ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");

                if (name == "Zelda")

                {
                    Console.WriteLine("List aborted! Zelda found!");
                    break;
                }



            }
        }
    }
}
