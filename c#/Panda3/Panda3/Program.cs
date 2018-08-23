using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] twoArray = new int[2];

            twoArray[0] = intArray[0];
            twoArray[1] = intArray[1];

            for (int i = 2; i < intArray.Length; i++)
            {
                intArray[i - 2] = intArray[i];
            }

            intArray[intArray.Length - 2] = twoArray[0];
            intArray[intArray.Length - 1] = twoArray[1];

            foreach (int item in intArray)
            {
                Console.Write(item);
            }



            //List<int> nummerList = new List<int>();
            //List<int> nummer = nummerList;

            //nummerList.Add(1);
            //nummerList.Add(2);
            //nummerList.Add(3);
            //nummerList.Add(4);
            //nummerList.Add(5);
            //nummerList.Add(6);


            //int first = .First;
            //linkedList.RemoveFirst();
            //linkedList.AddLast(first);


            //for (int i = 0; i < nummer.Count; i++)
            //{
            //    Console.Write(nummer[i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < nummer.Count; i++)
            //{
            //    Console.Write( nummer[i] + ", ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();





            //Write a function that rotates a list 
            //by k elements. For example [1,2,3,4,5,6] rotated by two becomes [3,4,5,6,1,2].
        }
    }
}
