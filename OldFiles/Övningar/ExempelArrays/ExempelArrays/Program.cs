using System;

namespace ExempelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa vektorn:
            int[] temperature = new int[5];

            temperature[0] = 17;
            temperature[1] = -65;
            temperature[2] = -20;
            temperature[3] = 9;
            temperature[4] = 42;

            //Lägg samman värdet på de olika elementen i arrayen och skriv ut:
            int sum = temperature[0] + temperature[1] + temperature[2] + temperature[3] + temperature[4];
            Console.WriteLine("Medeltemperaturen är: " + sum / 5);
            
            //Skriv ut elementet med index 0 och 5 (element 5 finns inte i arrayen, kompilatorn kommer inte säga ifrån men det kommer bli fel.)
            //Console.WriteLine("Första elementet: " + temperature[0]);
            //Console.WriteLine("Sjätte elementet: " + temperature[5]);// Fel!
        }
    }
}
