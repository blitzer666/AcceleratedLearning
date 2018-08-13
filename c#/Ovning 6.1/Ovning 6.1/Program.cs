using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_6._1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            var bob = new Circle("Bob", 8);
            var lisa = new Circle("Lisa", 30);

            bob.SayHello();
            lisa.SayHello();

            bob.WriteArea();
            lisa.WriteArea();
            Console.WriteLine();
        }
    }
}
