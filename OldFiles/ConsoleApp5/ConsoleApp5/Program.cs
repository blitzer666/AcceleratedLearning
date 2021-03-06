﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        
        {
            DoYouNeedToSleep();
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
    
    }
}
