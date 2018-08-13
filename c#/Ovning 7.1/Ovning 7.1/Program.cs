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
            List<Shapes> Myshapes = new List<Shapes>();

            
            while ( true)
            {
                Console.WriteLine("Select from the menu");
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one ");
                string menuChoice = (Console.ReadLine());
                
                if (menuChoice == "T" || menuChoice == "t")
                {
                    var triangle = new Triangle();
                    Console.WriteLine("Skriv in sida 1");
                    
                    int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in sida 2");
                    triangle.
                }
                else if (menuChoice == "R" || menuChoice == "r")
                {
                    Console.WriteLine("Skriv in sida 1");
                    var rectangle = MyRectangle();
                    Rectangle.. = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in sida 2");
                   
                }
                else if (menuChoice == "C" || menuChoice == "c")
                {
                    Console.WriteLine("Enter radius");
                    var circle = new MyCircles();
                    circle.radius = int.Parse(Console.ReadLine());
                    Myshapes.Add(circle);
                }
                else if (menuChoice == "D" || menuChoice == "d")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val!");
                }
                foreach (string item )
            }


           


              
        }
    }
}
