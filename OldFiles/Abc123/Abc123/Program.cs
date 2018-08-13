using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace Abc123
{
    //Klass
    class Program
    {
        //Metod
        static void Main(string[] args)
        {
            Console.WriteLine("In Main");
            PrintStuff("test1");
            PrintStuff("test2");
            Console.WriteLine("Leaving Main");

            Person.CelebrateBirthday();
        }
        static void PrintStuff(string valueToPrint)
        {
            Console.WriteLine("In PrintStuff");
            Console.WriteLine(valueToPrint);
            Console.WriteLine("Leaving PrintStuff");

        }
    }
}
