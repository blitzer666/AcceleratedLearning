using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexering
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[3];
            string[] names = { "Bo", "Li", "An"};
            //PrintLastName(names);
            PrintAllNames(names);
        }
        static void PrintLastName(string[] names)
        {
            string name = names[names.Length -1];
            Console.WriteLine(name);
        }
        static void PrintAllNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
//names[0] = "Bo"; //Första positionen
//names[1] = "Li";
//names[2] = "An"; //Sista positionen

//string name = names[0];
//Console.WriteLine(name);
//string firstName = names[0];
//string lastName = names[names.Length - 1]; // (names.Lenght = 3)
