using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Böcker
{

  

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();


            
            var b1 = new Book();
            var e1 = new ElectronicBook();

            b1.SetIsbn("978-3-16-148410-0");
            b1.SetAuthor("Kalle");
            b1.SetrNrOfPages(400);
            b1.SetProductId(1234);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:             {b1.GetIsbn()}");
            Console.WriteLine($"   Författare:       {b1.GetAuthor()}");
            Console.WriteLine($"   Antal sidor:      {b1.GetNrOfPages()}");
            //Console.WriteLine($"   Vikt:             {b1.WeigtInGram()} gram");
            Console.WriteLine($"   Storlek:          {b1.Size()}");
            Console.WriteLine($"   Produktens id:    {b1.GetProductId()}");

            Console.WriteLine();
            Console.WriteLine($"Olika test:");
            Console.WriteLine();

            Console.WriteLine($"   Är b1 en bok?     {b1 is Book}");
            //Console.WriteLine($"   Är b1 en e-bok?   {b1 is ElectronicBook}");
            Console.WriteLine($"   Är b1 en produkt? {b1 is Product}");

            Console.WriteLine();

            //Console.WriteLine($"   Är e1 en bok?     {e1 is Book}");
            Console.WriteLine($"   Är e1 en e-bok?   {e1 is ElectronicBook}");
            Console.WriteLine($"   Är e1 en produkt? {e1 is Product}");

            Console.WriteLine();
            Console.WriteLine($"Anrop:");
            Console.WriteLine();
            e1.SendBookTo("oo@happybits.se");

            Console.WriteLine();
        }

    }

}

// ctor kort för konstruktor (int name, int age två värden)






