using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeCsharp
{
    public class Nr4
    {
        public static void SpeedCamera()
        {

            //Console.Write("Enter the speedlimit: ");
            //int speedLimitInput = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            int speedLimitInput = AskForNumber("Enter the speedlimit: ");

            //Console.Write("Enter speed of the car: ");
            //int speedOfTheCar = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            int speedOfTheCar = AskForNumber("Enter the speedOfTheCar: ");


            int overLimit = speedOfTheCar - speedLimitInput;
            int demeritPoints = overLimit / 5;



            if (demeritPoints > 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("LICENSE SUSPENDED!");
                Console.ResetColor();
            }
            else if (speedOfTheCar > speedLimitInput)
            {
                Console.WriteLine("You now have " + demeritPoints + " demeritpoints");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ok");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.ReadLine();


        }

        private static int AskForNumber(string text)
        {
            Console.Write(text);
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return answer;
        }
    }
}




//        Your job is to write a program for a speed camera.Write a program that asks 
//        the user to enter the speed limit.Once set, the program asks for the speed of a car.
//        If the user enters a value less than the speed limit, program should display "Ok" 
//        on the console.If the value is above the speed limit, the program should calculate the number 
//        of "demerit points". For every 5km/hr above the speed limit, 1 demerit points should be incurred 
//        and displayed on the console. If the number of demerit points is above 12, the program should display "License Suspended."



