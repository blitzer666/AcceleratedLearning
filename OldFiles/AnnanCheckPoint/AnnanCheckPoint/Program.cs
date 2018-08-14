using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnanCheckPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange kommando: ");
            string userInput = Console.ReadLine();
            string[] storeUserInput = userInput.Split('-');

            Console.WriteLine();

            foreach (string item in storeUserInput)
            {
                int numberUserInput = Convert.ToInt32(item);


                for (int i = 0; i < numberUserInput; i++)
              //for (int i = 0; i < userNumber; i++)

                {


                    for (int j = 0; j < i; j++)
                  //for (int j = 0; j < userNumber; j++)
                    {
                        Console.Write("*");

                    }

                    Console.WriteLine("*");


                }
            }

    }
}
}
