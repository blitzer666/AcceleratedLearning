using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel736
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange temperatur: ");
            string str = Console.ReadLine();
            int temperature = Convert.ToInt32(str);
            while (temperature < 100)
            {
                temperature++; //++ är en räkneoperator som ökar värdet med 1
                Console.WriteLine("Temperaturen är nu " + temperature);
            }
            Console.WriteLine("Vattnet kokar!");
        }
    }
}
