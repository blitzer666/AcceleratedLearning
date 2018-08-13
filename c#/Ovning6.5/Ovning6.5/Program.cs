using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ankeborgorten = new Adress();
            Ankeborgorten.Street = "Anksvängen";
            Ankeborgorten.StreetNr = 13;
            Ankeborgorten.City = "Ankeborg";
            Ankeborgorten.SetZipCode("123 45");

            Console.WriteLine("Street      " + Ankeborgorten.Street);
            Console.WriteLine("StreetNr    " + Ankeborgorten.StreetNr);
            Console.WriteLine("City        " + Ankeborgorten.City);
            Console.WriteLine("ZipCode     " + Ankeborgorten.ZipCode);
            Console.WriteLine("FullAdress  " + Ankeborgorten.GetFullAdress());
            Console.WriteLine();

            
        }




                
        
    }
}
