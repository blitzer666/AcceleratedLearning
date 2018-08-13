using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string input1 = Console.ReadLine();

            Console.Write("How old are you? ");
            string input2 = Console.ReadLine();
            
            Console.Write("What is your favorite letter? ");
            string input3 = Console.ReadLine();

            Console.Write("What is the name of your favorite pet? ");
            string input4 = Console.ReadLine();

            Console.Write("What day is it? ");
            string input5 = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine( );
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is: " + input1);
            Console.WriteLine("You are " + input2 + "old.");
            Console.WriteLine("your favorite letter is " + input3);
            Console.WriteLine("The name of your favorite pet is " + input4);
            Console.WriteLine("Its " + input5 + " today");


            Console.ResetColor();

            Console.WriteLine();

        }
    }
}
