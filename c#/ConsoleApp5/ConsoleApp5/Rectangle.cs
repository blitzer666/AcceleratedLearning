using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Rectangle : Shape
    {
        double _height;
        double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return $"I'm a rectangle with height={_height} and width={_width}";
        }
    }
}