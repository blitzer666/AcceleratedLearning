using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the word");
            string input = Console.ReadLine();
            if (input == "Bear")
                Console.WriteLine("You Lucky Bastard!");
            else
                Console.WriteLine("You guessed wrong");
        }
        
        static void WriteName(string name, int age)
        {
            Console.WriteLine("Skriv ditt namn");
            string input = Console.ReadLine();

        
        }
    }
}
