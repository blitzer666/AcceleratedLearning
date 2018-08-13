using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange, vad är vatten: ");
            string water = Console.ReadLine () ;
            if (water == "blött")
            {
                Console.WriteLine("Ja vattnet är blött!");
            }
        }
    }
}
