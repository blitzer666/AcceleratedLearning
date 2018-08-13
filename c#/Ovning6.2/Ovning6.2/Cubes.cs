using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6._2
{
    class Cube
    {
     
        private double cubeSide1;
        private double cubeSide2;
        private double cubeSide3;

        public Cube(double x, double y, double z)
        {
            cubeSide1 = x;
            cubeSide2 = y;
            cubeSide3 = z;
        }

        public void WriteVolume()
        {
            double cubeVolume = Math.Round(cubeSide1*cubeSide2*cubeSide3);
            Console.WriteLine("The volume of the cube is " + cubeVolume);
        }



    }
}
