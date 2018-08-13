using System;

namespace Ovning_3._2_While
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your name: ");
            string name = (Console.ReadLine());


            Console.Write("How many times to repeat?");
            int repeat = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(name);
            }


        }
    }
}
