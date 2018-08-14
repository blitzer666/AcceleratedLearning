using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public override string ToString()
        {
            return "I'm a shape";
        }
    }
}