
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public string Name { get; set; }
        abstract public double CalculateArea();
    }

    class Colors
    {
        public string Color { get; set; }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }

    class Rectangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            double area = Base * Height;
            return area;
        }
    }

    class Triangle : Shape
    {
        public double Top { get; set; }
        public double Base { get; set; }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
