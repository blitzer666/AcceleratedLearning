using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_735
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange nummer: ");
            string str = Console.ReadLine();
            int nr = Convert.ToInt32(str);
            switch (nr)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }
        }
    }
}
