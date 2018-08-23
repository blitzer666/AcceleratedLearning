using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaOvningar
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "grönt";

            // Console.WriteLine(x[4]);

            //Console.WriteLine(x.Length);


            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}

            //for (int i = 0; i<=5; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}



            //while (true)
            //{


            //    Console.WriteLine("Enter a palindrome: ");

            //    string userInput = Console.ReadLine();

            //    for (int i = 0; i < userInput.Length - 1 / 2; i++)
            //    {

            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
        }

        //{


        //    for (int i = 1; i <= 12; i++)
        //    {
        //        for (int j = 1; j <= 12; j++)
        //        {
        //            Console.WriteLine($"{i} * {j} ={i * j}");
        //        }
        //    }
        //}
        //{
        //    //PandaTwo();
        //    PandaThree();
        //}

        //private static void PandaThree()
        //{
        //    Console.WriteLine("Enter a number");
        //    var n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Vill du multiplicera eller addera m/a? ");
        //    string Reply = Console.ReadLine();

        //    int summa = 0;

        //    if (Reply == "m")
        //        summa = 1;
        //    else if (Reply == "a")
        //        summa = 0;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (Reply == "m")
        //            summa = summa * i;
        //        else if (Reply == "a")
        //            summa = summa + i;

        //    }
        //    Console.WriteLine(summa);
        //}

        //private static void PandaTwo()
        //{
        //    Console.WriteLine("Enter a number");
        //    var n = int.Parse(Console.ReadLine());

        //    int summa = 0;


        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i % 3 == 0 || i % 5 == 0)
        //            summa = summa + i;

        //    }
        //    Console.WriteLine(summa);
        //}



        //while (true)
        //{
        //    Console.WriteLine("Write your name");
        //    var userInput = Console.ReadLine();
        //    Console.WriteLine();

        //    if (userInput == "Bob" || userInput == "Alice")
        //        Console.WriteLine("Hello " + userInput + "!");
        //}

    }
}
