using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When did you go to sleep yesterdag? ");
            int bedTime = int.Parse(Console.ReadLine());
            Console.WriteLine("When did you wake up?");
            int wakeUpTime = int.Parse(Console.ReadLine());

            var totalSleepTime = 24 - bedTime + wakeUpTime;

            Console.WriteLine("You slept for " + totalSleepTime + " hours");


        }
    }
}




