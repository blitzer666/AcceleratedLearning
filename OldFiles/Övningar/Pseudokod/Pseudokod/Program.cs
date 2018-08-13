using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudokod
{
    class Program
    {
        static void Main(string[] args)
        {//START
            Console.WriteLine("Skriv in två tal som du vill addera");
            Console.WriteLine();
            Console.Write("Tal 1: ");
            string number1 = Console.ReadLine(); // Läs in Tal 1
            int nr1 = Convert.ToInt32(number1);
            Console.Write("Tal 2: ");
            string number2 = Console.ReadLine(); // Läs in Tal 2
            int nr2 = Convert.ToInt32(number2);
            int sum = nr1 + nr2; //Summa = Tal 1 + Tal 2
            Console.WriteLine();
            Console.WriteLine("Tal 1 + Tal 2 = " + sum); // Skriv ut summa
            Console.WriteLine();
            //STOP
        }
    }
}
