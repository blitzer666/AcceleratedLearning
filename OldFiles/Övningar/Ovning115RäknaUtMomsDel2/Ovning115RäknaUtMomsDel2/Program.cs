using System;

namespace Ovning115RäknaUtMomsDel2
{
    class Program
    {

        static double CalculateVat(int price)
        {
            int ammount = 100;
            return ammount;

        }

        static void Main(string[] args)

        {
            Console.Write("Ange moms: ");
            try
            {
                double vat = Convert.ToDouble(Console.ReadLine());
                double sum = vat * 4;
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("Du får bara skiva siffror");
            }
        }
    }
}
