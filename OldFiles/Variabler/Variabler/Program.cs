using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static string test = "Test-värdet...";

        static void Main(string[] args)
        {
            string firstName = "Pontus";
            firstName += "!";

            string uppercaseFirstName = firstName.ToUpper();
            int stringLength = uppercaseFirstName.Length;

            Console.WriteLine(uppercaseFirstName);
            Console.WriteLine(stringLength);

            Console.WriteLine(FormatName("Bo", "Boman"));
            Console.WriteLine(FormatName("Li", "Boman"));

            
            Console.WriteLine(test);

            Console.WriteLine("Ange din ålder...");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            age++;
            Console.WriteLine("Din ålder är (nästa år): " + age);
        }
        static string FormatName(string firstName, string lastName)
        {
            Console.WriteLine(test);
            return lastName + ", " + firstName;
        }
    }
}
