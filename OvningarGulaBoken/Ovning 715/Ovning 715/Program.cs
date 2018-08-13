using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_715
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ange den första karaktären");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ange den andra karaktären");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hej " + name1 + " & " + name2 + "!" + " Vill ni läsa den spännande historien om er själva? j/n:");
                       
                string input = Console.ReadLine();
            if (input == "j")
                Console.WriteLine("Roligt att höra " + name1 + " & " + name2 + "." + " " + "Då kör vi!");
            else if (input == "n")
                Console.WriteLine("Det var ju tråkigt men ni får höra den ändå! ");
                     
            string story1 = "Det var en gång två skogshuggare som hette " + name1 + " & " + name2 + ". ";
            string story2 = "En dag skulle " + name1 + " & " + name2 + " gå till den stora festen som varje år hölls inne i staden.";
            
            string everything = story1 + story2;

            Console.WriteLine(everything);

            //Console.WriteLine("Ange den första karaktären");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Ange den andra karaktären");
            //string name2 = Console.ReadLine();
            //string story1 = "Det var en gång två skogshuggare som hette ";
            //string story2 = "En dag skulle ";
            //string story3 = "gå till den stora festen som varje år hölls i staden.";

            //string everytning1 = story1 + name1 + " & " + name2 + ".";
            //string everytning2 = story2 + name1 + " & " + name2 + " ";

            //Console.WriteLine(everytning1 + everytning2 + story3);


            //string mystring1 = "Detta är en textsträng!";
            //string mystring2 = "Jag plussar ihop den med en annan sträng, samt siffran";
            //int nr = 25;
            //string everything = mystring1 + "" + mystring2 + nr;
            //Console.WriteLine(everything);
        }
    }
}
