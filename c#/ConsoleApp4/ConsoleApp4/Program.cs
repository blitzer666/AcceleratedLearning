
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>();

            string input = "";

            while (input != "D")
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                input = Console.ReadLine().ToUpper();

                if (input == "T")
                {
                    var triangle = AskForTriangle();
                    allShapes.Add(triangle);

                }
                else if (input == "R")
                {
                    var rectangle = AskForRectangle();
                    allShapes.Add(rectangle);
                }
                else if (input == "C")
                {
                    var circle = AskForCircle();
                    allShapes.Add(circle);
                }
            }
            PrintAllShapes(allShapes);
        }

        private static Rectangle AskForRectangle()
        {
            var rectangle = new Rectangle();
            rectangle.Name = "rectangle";
            Console.Write("Enter base of rectangle: ");
            rectangle.Base = AskForNumber();
            Console.Write("Enter height of rectangle: ");
            rectangle.Height = AskForNumber();
            return rectangle;

        }

        private static Triangle AskForTriangle()
        {
            var triangle = new Triangle();
            triangle.Name = "triangle";
            Console.Write("Enter top of triangle: ");
            triangle.Top = AskForNumber();
            Console.Write("Enter base of triangle: ");
            triangle.Base = AskForNumber();
            return triangle;
        }

        private static Circle AskForCircle()
        {
            var circle = new Circle();
            circle.Name = "circle";
            Console.Write("Enter radius of circle: ");
            circle.Radius = AskForNumber();
            return circle;
        }

        private static double AskForNumber()
        {
            double question = double.Parse(Console.ReadLine());
            return question;
        }

        private static void PrintAllShapes(List<Shape> allShapes)
        {
            foreach (var item in allShapes)
            {
                Console.WriteLine($"I have an {item.CalculateArea()} of cm");
            }
        }
    }
}