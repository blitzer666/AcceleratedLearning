using System;

namespace Ovning_3._2_While
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your name: ");
            string name = (Console.ReadLine());

            
            Console.Write("How many times to repeat?" );
            int repeat = int.Parse(Console.ReadLine());

            int rep = 0;

            while(rep < repeat)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine(name);
                rep++;
                Console.ResetColor();

             
            }

            
        }
    }
}
