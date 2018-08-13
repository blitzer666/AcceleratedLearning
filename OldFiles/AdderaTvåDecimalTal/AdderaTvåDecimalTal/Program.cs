using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdderaTvåDecimalTal
{
    class Program
    {
        static void Main(string[] args)
        {
            double nr1 = 0;
            double nr2 = 0;
            bool loop = true;
            do
            {
                Console.Write("Tal 1: ");
                string strNr1 = Console.ReadLine();
                Console.Write("Tal 2: ");
                string strNr2 = Console.ReadLine();
                try
                {
                    nr1 = Convert.ToDouble(strNr1);
                    nr2 = Convert.ToDouble(strNr2);
                    loop = false;

                }
                catch
                {
                    Console.WriteLine("Fel! Du kan bara skriva tal!");
                }
            } while (loop);
            double sum = nr1 + nr2;
            Console.WriteLine(nr1 + " + " + nr2 + " = " + sum);

        }
    }
}