using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning735del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange temperatur för Östersund: ");
            int ostersund = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange temperatur för Åmål: ");
            int amal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange temperaturen för Arboga: ");
            int arboga = Convert.ToInt32(Console.ReadLine());

            if (ostersund < amal && ostersund < arboga)
            {
                Console.WriteLine("Det är kallast i Östersund ");
            }
            else if (amal < ostersund && amal < arboga)
            {
                Console.WriteLine("Det är kallast i Åmål");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga");
            }
                

        }
    }
}
