using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Code: ");
            string userInput = Console.ReadLine();
            string[] storeUserInput = userInput.Split('-');

            foreach (string item in storeUserInput)
            {
                int listNumber = Convert.ToInt32(item);
                for (int i = 0; i < listNumber; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("A");
                    }
                    Console.WriteLine("A");
                }
            }
                

        }
    }
}
