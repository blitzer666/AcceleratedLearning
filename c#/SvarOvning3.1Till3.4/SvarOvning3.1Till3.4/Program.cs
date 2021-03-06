﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvarOvning3._1Till3._4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InitConsole();

            // 3.1 If statement
            // DoYouNeedToSleep();

            //// 3.2 While
            //RepeatNameWithWhile();

            //// 3.3 For
            //RepeatNameWithFor();

            //// 3.4 Foreach
            //SplitAndForeach();


            EndProgram();

        }

        // If statement

        private static void DoYouNeedToSleep()
        {
            // 21 6      (24-21) + 6       
            // 22 6      (24-22) + 6 
            // 23 6      (24-23) + 6
            // 0  6      6 - 0
            // 1  6      6 - 1

            Console.Write("When did you go to bed yesterday? ");
            int toSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wokeUp = int.Parse(Console.ReadLine());

            int sleepTime;

            if (toSleep > wokeUp)
                sleepTime = wokeUp + (24 - toSleep);
            else
                sleepTime = wokeUp - toSleep;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            if (sleepTime < 6)
            {
                Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
            }
            else if (sleepTime > 12)
            {
                Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
            }
            else
            {
                Console.WriteLine($"You have slept well. ({sleepTime} hours)");
            }

        }

        //  While loop

        private static void RepeatNameWithWhile()
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            int counter = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            while (counter < repeat)
            {
                Console.WriteLine($"Your name is {yourName}");
                counter++;
            }

        }

        // For loop

        private static void RepeatNameWithFor()
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            for (int counter = 0; counter < repeat; counter++)
            {
                Console.WriteLine($"Your name is {yourName}");
            }

        }

        //  Foreach loop 

        private static void SplitAndForeach()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }
        }

        private static void InitConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 60;
            Console.WindowHeight = 7;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

        private static void EndProgram()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}