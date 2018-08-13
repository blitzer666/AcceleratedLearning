using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning753
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Hur många gånger vill du singla slanten?");
                Console.WriteLine();
                string howManyTimes = Console.ReadLine();
                Random rnd = new Random();
                
                int count = Convert.ToInt32(howManyTimes);
                for (int i = 0; i < count; i++)
                {
                    int resultat = rnd.Next(1, 3);


                    if (resultat == 1)
                        Console.WriteLine("Klave");
                    else if (resultat == 2)
                        Console.WriteLine("Krona");
                    Console.ReadLine();
                    
                }
                Console.WriteLine("======================================================================");
                Console.WriteLine("Tack för att du singlade slant! ");
                Console.WriteLine();

            }
        }
    }
}
