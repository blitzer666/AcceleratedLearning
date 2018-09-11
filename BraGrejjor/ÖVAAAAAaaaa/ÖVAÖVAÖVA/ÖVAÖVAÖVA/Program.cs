using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVAÖVAÖVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int timesToRepeat = int.Parse(Console.ReadLine());

            int counter = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            string message1 = ($"Your name is {name}");
            string message2 = ("Your name is " + name);
            string message3 = string.Format("Your name is {0}", name);
           

            while (counter < timesToRepeat)
            {
                Console.WriteLine(message1);
                Console.WriteLine(message2);
                Console.WriteLine(message3);
               
                counter++;
            }
            Console.ResetColor();
            Console.ReadKey();



        }
    }
}
    


