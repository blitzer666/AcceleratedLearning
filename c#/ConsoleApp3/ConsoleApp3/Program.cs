using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange Kommando ");
            var str = Console.ReadLine().Split('-');



            int[] triangle = str.Select(d => Convert.ToInt32(d)).ToArray();

            foreach (int item in triangle)
            {
                for (int i = 0; i < item; i++)
                {
                    Console.Write("*");

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
            }

        }
    }
}
