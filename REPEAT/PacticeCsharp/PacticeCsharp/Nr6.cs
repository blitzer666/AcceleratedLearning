using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeCsharp
{
    public class Nr6
    {
        public static void TheSumOfEnteredNumbers()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "OK")
                {
                    break;
                }

                int number = int.Parse(answer);
                sum += number;
            }
            Console.WriteLine("Summan är " + sum);

            Console.WriteLine("SLUT!");

            Console.ReadKey();

        }
    }
}



/*Write a program and continuously ask the user to enter a number.
The loop terminates when the user enters “ok". Calculate the sum
of all the previously entered numbers and display it on the console.*/
