using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktlista
{
    class Program
    {


        static void Main(string[] args)

        // Jag fastnade totalt på denna uppgift. Jag har lagt mycket tid men har tyvärr inte kunnat lägga den tid jag önskat på att plugga då jag fortfarande atbetar på mitt nuvarande jobb (kommer inte att vara kvar där när utbildningen börjar).
        //Nedan hittar du mitt försök till att lösa uppgiften...

        {
            while (true)
            {
                Console.WriteLine("välj en produkt eller skriv exit om du är klar.");
                Console.WriteLine();
                Console.WriteLine("ab-1234");
                Console.WriteLine("xyz-5000");
                Console.WriteLine("laban");
                Console.WriteLine("kalle");
                Console.WriteLine("exit");
                Console.WriteLine();

                string menuselection = Console.ReadLine();

                if (menuselection == "AB-1234" || menuselection == "ab-1234")
                {

                }



                else if (menuselection == "XYZ-5000" || menuselection == "xyz-5000")

                {

                }

                else if (menuselection == "LABAN" || menuselection == "laban")

                {

                }

                else if (menuselection == "KALLE" || menuselection == "kalle")

                {

                }
                else if (menuselection == "EXIT" || menuselection == "exit")

                {
                    break;
                }
                else
                {
                    Console.WriteLine("ogiltigt val!");


                }
            }

        }
    }
}







//{
//    //string[] productName = new string[] { "AB-1234", "ab-1234", "XYZ-5000", "xyz-5000", "LABAN", "laban", "KALLE", "kalle" };
//    string[] product = new string[5];
//    product[0] = "AB-1234";
//    product[1] = "XYZ-5000";
//    product[2] = "laban";
//    product[3] = "kalle";          


//  }

























//Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");
//Console.WriteLine();
//Console.WriteLine("AB-1234");
//Console.WriteLine("XYZ5000");
//Console.WriteLine("laban");
//Console.WriteLine("kalle");
//Console.WriteLine("exit");
//string input = Console.ReadLine();
//Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");
//        string str = Console.ReadLine();
//        int nr = Convert.ToInt32(str);

//        while (true)
//        switch (nr)
//        {
//            case 1:
//                Console.WriteLine("case1");
//                break;

//            case 2:
//                Console.WriteLine("case 2");
//                break;

//            default:
//                Console.WriteLine("default case");
//                break;
//        }
//        }



//}
//}
