using System;

namespace Ovning116
{
    class Program
    {
        static void Main(string[] args)
          
        {
            Console.Write("Ange ett decimaltal: ");
            ToPercentage();
            
        }
        static void ToPercentage()
           
        {
            while (true)
                try
            {
                string str = Console.ReadLine();
                double decimalTal = Convert.ToDouble(str);
                decimalTal = (decimalTal * 100);
                Console.WriteLine("Detta är ditt heltal: " + decimalTal);
            }
            catch
            {
                Console.WriteLine("Ogiltigt val!");
            }
            

          
        }
    }
}
