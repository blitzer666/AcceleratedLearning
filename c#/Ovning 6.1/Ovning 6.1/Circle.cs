using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_6._1
{
    public class Circle
    {

        private string name;
        private double radie;

        public Circle(string x, double y)
        {
            name = x;
            radie = y;
        }

        public void SayHello()
        {
            Console.WriteLine("im a circle with the name " + name);


        }
        public void WriteArea()
        {
            double circleRadie = Math.Round(Math.PI * radie * radie,2);
            Console.WriteLine("My name is " + name + ". i have the radius of " + circleRadie );
        }
       




    }


}
