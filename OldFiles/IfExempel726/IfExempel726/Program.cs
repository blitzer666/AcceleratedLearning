using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExempel726
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange tmperatur");
            string str = Console.ReadLine();
            int temperature = Convert.ToInt32(str);
            if (temperature == 100)
            {
                Console.WriteLine("Nu kokar vattnet!");
            }
            else
                Console.WriteLine("Vattnet är inte exakt 100 grader");
            
        }
    }
}
