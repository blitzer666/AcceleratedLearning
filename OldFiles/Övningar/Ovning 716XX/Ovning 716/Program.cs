using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_716
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett tal:");
            Console.WriteLine();
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());

            tal1 = Math.Round(tal1, 2);
            tal2 = Math.Round(tal2, 2);


            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
        }
    }
}
