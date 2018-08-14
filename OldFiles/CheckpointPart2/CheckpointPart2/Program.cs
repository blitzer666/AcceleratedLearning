using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckpointPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated with spaces ");
            string userInput = Console.ReadLine();
            //char[] whitespace = new char[] { ' ', '\t' };
            string[] storeUserInput = userInput.Split(' ');//fungerade med mellanslag
                                                            //mellan ' ' istället för white...


            foreach (string item in storeUserInput)
            {
                int userNumber = Convert.ToInt32(item);

                for (int i = 0; i < userNumber; i++)
                {
                    for (int j = 0; j < userNumber; j++)
                        
                    {
                        Console.Write("O");
                    }
                    Console.WriteLine("O");
                   
                }
                Console.WriteLine(); //Måste vara längst ner 
                                     //för att få mellanrum på rätt ställe...
            }
        }
    }
}

