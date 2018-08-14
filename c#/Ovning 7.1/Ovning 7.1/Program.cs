using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_7._1
{
    class Program
    {



        static void Main(string[] args)
        {
            List<Shape> Myshapes = new List<Shape>();


            while (true)
            {
                Console.WriteLine("Select from the menu");
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one ");
                string menuChoice = (Console.ReadLine());

                if (menuChoice == "T" || menuChoice == "t")
                {
                    var triangle = AskForTriangle();
                    Myshapes.Add(triangle);

                    //Console.WriteLine("Skriv in sida 1");
                    //var triangle = new Triangle();
                    //triangle.Base = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Skriv in sida 2");
                    //var rectangle2 = new Triangle();
                    //triangle.Top = int.Parse(Console.ReadLine());
                }
                else if (menuChoice == "R" || menuChoice == "r")
                {
                    Console.WriteLine("Skriv in sida 1");
                    var rectangle = new Rectangle();
                    rectangle.Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in sida 2");
                    var rectangle2 = new Rectangle();
                    rectangle.Height = int.Parse(Console.ReadLine());

                }
                else if (menuChoice == "C" || menuChoice == "c")
                {
                    Console.WriteLine("Enter radius");
                    var circle = new Circle();
                    circle.Radius = int.Parse(Console.ReadLine());
                    //Myshapes.Add();
                }
                else if (menuChoice == "D" || menuChoice == "d")
                {
                    Console.WriteLine("PUH");
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val!");
                }
            }
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
        private static double AskForNumber()
        {
            double question = double.Parse(Console.ReadLine());
            return question;
        }



    }
}











