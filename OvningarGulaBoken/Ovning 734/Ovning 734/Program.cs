using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_734
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange temperaturen i Östersund: ");
            string temperatur1 = Console.ReadLine();
            int nr1 = Convert.ToInt32(temperatur1);
            Console.WriteLine("Ange temperaturen i Åmål" );
            string temperatur2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(temperatur2);
            if (nr1 < nr2)
                Console.WriteLine("Det är Kallast i Östersund");
            else if (nr1 > nr2)
                Console.WriteLine("Det är kallast i Åmål");
            else
                Console.WriteLine("Det är samma temperatur i Östersund och Åmål");




        }
    }
}
