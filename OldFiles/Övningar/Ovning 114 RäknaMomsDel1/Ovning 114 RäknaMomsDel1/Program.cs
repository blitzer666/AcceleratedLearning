using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_114_RäknaMomsDel1
{
    class Program
    {

        static void CalculateVat()
        {
            Console.WriteLine("Ange summa utan moms: ");
            double priceWithoutVat = Convert.ToDouble(Console.ReadLine());

            double sum = (priceWithoutVat * 1.25);
            Console.WriteLine("Din summa plus moms blir: " + sum);
        }

        static void Main(string[] args)
        {
            CalculateVat();
        }
    }
}
