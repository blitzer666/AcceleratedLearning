using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr1 = 1000, nr2 = 2000, nr3 = 13;
            Console.WriteLine("1000 + 2000 * 13 =");
            int sum = nr1 + nr2 * nr3;
            Console.WriteLine(sum);
        }
    }
}
