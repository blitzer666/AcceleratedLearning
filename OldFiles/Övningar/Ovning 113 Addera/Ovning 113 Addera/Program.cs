using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_113_Addera
{
    class Program
    {
        static void Main(string[] args)
        {
            addTwoNumbers();
        }
        static void addTwoNumbers()
        {
            Console.WriteLine("Ange två tal som du vill adddera: ");
            string strTal1 = Console.ReadLine();
            int Tal1 = Convert.ToInt32(strTal1);
            string strTal2 = Console.ReadLine();
            int Tal2 = Convert.ToInt32(strTal2);
            int sum = Tal1 + Tal2;
            Console.WriteLine(sum);
        }
        
    }
}
