using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning755
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Tryck på enter för att slå tärningen, du har sex försök på dig!");
                Console.WriteLine();
                string rollTheDice = Console.ReadLine();
                Random rnd = new Random();

                int count = Convert.ToInt32(6);
                for (int i = 0; i < count; i++)
                {
                    int resultat = rnd.Next(1, 7);


                    if (resultat == 1)
                        Console.WriteLine("Ett");
                    else if (resultat == 2)
                        Console.WriteLine("Två");
                    else if (resultat == 3)
                        Console.WriteLine("Tre");
                    else if (resultat == 4)
                        Console.WriteLine("Fyra");
                    else if (resultat == 5)
                        Console.WriteLine("Fem");
                    else if (resultat == 6)
                        Console.WriteLine("Sex");
                    Console.ReadLine();

                }
                Console.WriteLine();
                Console.WriteLine("Tack för att spelade Yatzy! ");
                Console.WriteLine();

            }
        }
    }
}