using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int retirement = 65;       

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string strage = Console.ReadLine();
            int age = Convert.ToInt32(strage);
            int


            Console.Write("What is your favorite character? ");
            char character  = char.Parse (Console.ReadLine());
             = char.Parse(answer);







            char.IsNumber();
                
            
                

            int sum = (retirement - age);


            Console.WriteLine("");

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("You have " + sum + " years until retirement.");            
            Console.WriteLine("your favorite letter is " + answer);

           

            Console.ResetColor();

            Console.WriteLine();

        }
    }
}
