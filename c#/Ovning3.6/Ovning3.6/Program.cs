using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you");
            int yourAge = int.Parse(Console.ReadLine());


            Console.WriteLine("Are you male or female? ");
            string gender = (Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (yourAge < 13)
            {
                Console.WriteLine("You are a child! ");
            }


            else if (yourAge < 18)
            {
                Console.WriteLine("You are a " + gender + " teenager");
            }

            else if (yourAge >= 18 && yourAge < 65)
            {
                Console.WriteLine("You are a " + gender + " adult");
            }

            else if (yourAge >= 65)
            {
                Console.WriteLine("You are an old " + gender);
            }


            //else if (number > compare)
            //{
            //    Console.WriteLine("Higher than " + compare);
            //}
            //else
            //{
            //    Console.WriteLine("Your number is equal to " + compare);
            //}

            //{
            //    Console.WriteLine("Enter a number");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What number to compare to? ");
            //    int compare = int.Parse(Console.ReadLine());



            //if (number < compare)
            //{
            //    Console.WriteLine("Lower than " + compare);
            //}

            //else if (number > compare)
            //{
            //    Console.WriteLine("Higher than " + compare);
            //}
            //else
            //{
            //    Console.WriteLine("Your number is equal to " + compare);
            //}





        }
    }
}
