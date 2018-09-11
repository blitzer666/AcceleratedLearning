using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodTimes = new List<string>();
            
            while (true)
            {
                string userInput = Console.ReadLine();
                string[] userInputList = userInput.Split('*');

                if (userInput == "exit")
                {
                    break;
                }
            }
            foreach (var item in goodTimes)
            {
                Console.WriteLine(item);
            }
           
            {

            }
        }
    }
}
