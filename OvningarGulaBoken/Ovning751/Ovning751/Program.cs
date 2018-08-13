using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning751
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Talen 1 till 20 kommer att skrivas ut:" );
            int str = 0;
            int startnumber = Convert.ToInt32(str);
            while (startnumber < 20)
            {
                startnumber++;
                Console.WriteLine(startnumber);

            }
            Console.WriteLine("Nu har talen 1 till 20 skrivits ut!");
        }
    }
}
