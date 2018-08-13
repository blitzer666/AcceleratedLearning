using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning754
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {              
                Console.WriteLine("Vill du fortsätta loopen?");
                 str = Console.ReadLine();
           
            } while (str == "j"); // Ändrade från = (tilldelningsoperatorn) till == (jämförelseoperatorn). Om man sättar = så försöker det att konvertera int till bool, som i c# inte är möjligt.

        }
    
    }
}
