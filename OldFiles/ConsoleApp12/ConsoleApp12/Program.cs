using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Command");
            string useriInput = Console.ReadLine();
            string[] storeuserInput = useriInput.Split('-');

            foreach(string item in storeuserInput)
            {
                int userNumber = Convert.ToInt32(item);
                for (int i = 0; i < userNumber; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }
        }

                

        
    }
}
