using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_714
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett decimaltal: ");
            float tal1 = float.Parse(Console.ReadLine());
            int nr = Convert.ToInt32(tal1);
            
            
           
            Console.WriteLine("Decimaltalet " + tal1 + " avrundas till heltalet " + nr);
           
        }
    }
}
