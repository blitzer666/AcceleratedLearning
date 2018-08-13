using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
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



//Console.WriteLine("Ange en lista bestående av siffror separerade med streck");
//string str = Console.ReadLine();
//int size = Convert.ToInt32(str);

//int[] triangleSize = new int[size];
//for (int i = 0; i < triangleSize.Length; i++)
//{
//    Console.WriteLine("Ange storlek" + i + "; ");
//    str = Console.ReadLine();
//    int element = Convert.ToInt32(str);

//    triangleSize[i] = element;
//}
//int sum = 0;
//for (int i = 0; i < triangleSize.Length; i++) sum = sum + triangleSize[i];
//Console.WriteLine(sum / triangleSize.Length);
