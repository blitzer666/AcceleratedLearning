using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            mycube.WriteVolume();
            supercube.WriteVolume();

            Console.WriteLine();
        }
    }
}