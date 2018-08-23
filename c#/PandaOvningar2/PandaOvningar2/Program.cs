using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaOvningar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that combines two lists by alternatingly taking elements, e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[3] = 5;

            string[] letters = new string[5];
            letters[0] = "a";
            letters[1] = "b";
            letters[2] = "c";
            letters[3] = "d";
            letters[4] = "e";

            Console.Write("[");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]); Console.Write(","); Console.Write(letters[i]); Console.Write(",");
            }

            Console.Write("]");
            Console.WriteLine();


            //Console.Write("[");
            //foreach (int number in numbers) 
            //{
            //    Console.Write(number + ", ");
            //}
            //Console.Write("]");
            //Console.Write("[");
            //foreach (string letter in letters)
            //{
            //    Console.Write(letter + " ,");


            //}
            //Console.Write("]");
            //Console.WriteLine();
            //Console.ReadLine();

        }
    }
}
