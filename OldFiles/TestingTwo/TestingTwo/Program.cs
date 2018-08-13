using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTwo
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input:"); // Prompt

                 string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    Console.Write("You typed "); // Report output
                    Console.Write(line);
                    Console.WriteLine(" character(s)");

                    break;
                }
               // Console.Write("You typed "); // Report output
                //Console.Write(line.Length);
                //Console.WriteLine(" character(s)");
            }
        }
    }
}
