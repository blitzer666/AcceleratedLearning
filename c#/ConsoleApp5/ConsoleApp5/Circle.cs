﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Circle : Shape
    {
        double _x;
        double _y;
        double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override string ToString()
        {
            return $"I'm a circle with radius={_radius}";
        }

        public override double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
