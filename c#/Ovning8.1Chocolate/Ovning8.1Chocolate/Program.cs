using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning8._1Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal chocolatePieces = 24;

            Console.WriteLine("The chocolate contains 24 pieces ");

            Console.Write("How many want to chare? ");

            Console.ForegroundColor = ConsoleColor.Green;

            try
            {

                decimal peopleToChare = int.Parse(Console.ReadLine());

                decimal sum = chocolatePieces / peopleToChare;


                Console.WriteLine("Everyone gets" + sum + " pieces");


            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;



                Console.WriteLine("Fel format");
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;



                Console.WriteLine("Zero people cant divide a chocolate");
                Console.ResetColor();
            }







        }
    }
}
