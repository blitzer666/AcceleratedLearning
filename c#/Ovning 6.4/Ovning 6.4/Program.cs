using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_6._4
{
    class Program
    {
        enum Sports
        {
            Tennis,
            Rugby,
            Soccer,
            Hurling,
            Squash
        };
        enum Gender
        {
            Male,
            Female,
            Other
        }



        static void Main()
        {
            {
                string name = Enum.GetName(typeof(Sports),
                    Sports.Tennis);
                Console.WriteLine(name);

                name = Enum.GetName(typeof(Sports),
                    3);
                Console.WriteLine(name);
            }



            var Lisa = new Person();
            Lisa.FirstName = "Lisa";
            Lisa.Lastname = "Andersson";
            Lisa.Birthday = 24 + " Juli";
            Lisa.Gender = "Female";
            Lisa.FavoriteSport = "Tennis";




            //// ... An enum local variable.
            //Importance value = Importance.Critical;

            //// ... Test against known Importance values.
            //if (value == Importance.Trivial)
            //{
            //    Console.WriteLine("Not true");
            //}
            //else if (value == Importance.Critical)
            //{
            //    Console.WriteLine("True");
            //}

        }
    }
}























//    {
//        static void Main(string[] args)
//        {

//            var Lisa = new Person();
//            lisa.FirstName = "Anksvängen";
//            Ankeborgorten.StreetNr = 13;
//            Ankeborgorten.City = "Ankeborg";
//            Ankeborgorten.ZipCode = 12345;

//            Console.WriteLine("Street      " + Ankeborgorten.Street);
//            Console.WriteLine("StreetNr    " + Ankeborgorten.StreetNr);
//            Console.WriteLine("City        " + Ankeborgorten.City);
//            Console.WriteLine("ZipCode     " + Ankeborgorten.ZipCode);
//            Console.WriteLine("FullAdress  " + Ankeborgorten.GetFullAdress());
//            Console.WriteLine();


//        }
//    }
//}
//public string FirstName { get; set; }
//public string Lastname { get; set; }
//public int Birthday { get; set; }
//public string gender { get; set; }
//public string FavoriteSport { get; set; }
