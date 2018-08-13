using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_737
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            string str = Console.ReadLine();
            int tal = Convert.ToInt32(str);
            while (tal != 42)
            {
                Console.WriteLine("Fel! Gissa igen: ");
                str = Console.ReadLine();
                tal = Convert.ToInt32(str);
            }
            Console.WriteLine("Grattis! du gissade rätt!");
        }
    }
}
