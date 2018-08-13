using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {

            int saldo = 0;


            bool running = true;
            while (running)
            {

                Console.WriteLine("VÄLKOMMEN TILL BANKEN");
                Console.WriteLine();
                Console.WriteLine("Gör ditt val: ");
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("[i]nsättning");
                Console.WriteLine("[u]ttag");
                Console.WriteLine("[s]aldo");
                Console.WriteLine("[A]vsluta");

                string inmatning = Console.ReadLine();

                switch (inmatning)
                {
                    case "I":
                    case "i":
                        Console.WriteLine("Sätt in ett belopp: ");
                        saldo = saldo + Convert.ToInt32(Console.ReadLine());
                        break;

                    case "U":
                    case "u":
                        Console.WriteLine("Ta ut ett belopp: ");
                        saldo = saldo - Convert.ToInt32(Console.ReadLine());
                        break;

                    case "S":
                    case "s":
                        Console.WriteLine("Det här är ditt saldo: " + saldo);
                        break;

                    case "A":
                    case "a":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("För in rätt kommando");
                        break;
                }
            }
        }
    }
}


 
