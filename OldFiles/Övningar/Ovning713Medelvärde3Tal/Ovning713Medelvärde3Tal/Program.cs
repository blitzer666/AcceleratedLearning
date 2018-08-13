using System;

namespace Ovning713Medelvärde3Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange tre heltal för att få reda på medelvärdet: ");
            Console.WriteLine();
            Console.Write("Ange tal 1: ");
            string str = Console.ReadLine();
            int nr1 = Convert.ToInt32(str);

            Console.Write("Ange tal 2: ");
            string str2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(str2);

            Console.Write("Ange tal 3: ");
            string str3 = Console.ReadLine();
            int nr3 = Convert.ToInt32(str3);

            int toghether = (nr1 + nr2 + nr3);
            int average = (toghether / 3);
        

            Console.WriteLine("Dina tal tillsammans är: " + toghether + ". " + "Medelvärdet är: " + average);
           



        }
    }
}
