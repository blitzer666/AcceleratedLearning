using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter names, type quit when done. ");

            //List<string> createList = Console.ReadLine.();
            List<string> createList = Console.ReadLine().Split(',').ToList();

            createList.Sort();
            foreach (var item in createList)
            {
                if (item.ToUpper() == "quit")
                {
                    Console.WriteLine(item);
                }
                
            }

           
        }
    }
}
