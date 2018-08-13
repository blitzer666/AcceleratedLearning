using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning712
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("skriv ett nummer: ");
            string strNr1 = Console.ReadLine();
            int nr1 = Convert.ToInt32(strNr1);
            Console.WriteLine("skriv nu numret du vill addera med");
            string strNr2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(strNr2);
            int sum = nr1 + nr2;
            Console.WriteLine("Summan blir: ");
            Console.WriteLine(sum);

        }
    }
}
