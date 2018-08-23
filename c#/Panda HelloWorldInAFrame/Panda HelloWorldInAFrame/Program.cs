using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda_HelloWorldInAFrame
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> frameList = new List<string>() { "Hello", "world", "in", "a", "frame" };


            Console.WriteLine("********");
            foreach (string frame in frameList)
            {
                
                Console.WriteLine($"*{frame.PadRight(6)}*");
            }
            Console.WriteLine("********");









        }
    }
}          