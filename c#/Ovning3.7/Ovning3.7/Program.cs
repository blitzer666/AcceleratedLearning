using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int yourNumber = int.Parse(Console.ReadLine());

            
            int compare = 20;

            var result = yourNumber > compare ? (yourNumber < compare) : (yourNumber == compare) ? "Your number is greater than 20" : "Your number is lower than 20";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(result);

            //{
            //    int x = 20, y = 10;

            //    string result2 = x > y ? 
            //        (x>10000 ? "x är jättestort": "x är bara störra än y") : 
            //        "x is less than or equal to y";
            //}

            //if (yourNumber < compare)
            //{
            //    Console.WriteLine("lower than " + compare);
            //}

            //else if (yourNumber > compare)
            //{
            //    Console.WriteLine("higher than " + compare);
            //}
            //else
            //{
            //    Console.WriteLine ("your number is equal to " + compare);
            //}

            //{
            //    Console.WriteLine("Enter a number");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What number to compare to? ");
            //    int compare = int.Parse(Console.ReadLine());



            //    if (number < compare)
            //    {
            //        Console.WriteLine("Lower than " + compare);
            //    }

            //    else if (number > compare)
            //    {
            //        Console.WriteLine("Higher than " + compare);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your number is equal to " + compare);
            //    }





        }    //}
    }
}
