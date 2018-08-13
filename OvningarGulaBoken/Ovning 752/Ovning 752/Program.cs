using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning751
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal mellan 1 och 100:");
            string str = Console.ReadLine();
            int number = Convert.ToInt32(str);

            while (number < 100)
            {
                number++;
                Console.Write(number + " ");

            } 

            {
                Console.WriteLine();
                               
            }
            

            
        }
    }
}