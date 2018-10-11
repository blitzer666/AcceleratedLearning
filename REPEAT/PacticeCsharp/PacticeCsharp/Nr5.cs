using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeCsharp
{
    public class Nr5
    {
        public static void DivisibleByThree_Shorter(int counter)
        {
           

            int numberOfNumbersDividableByThree = 0;

            for (int i = 1; i <= counter; i++)
            {
                if (i % 3 == 0)
                {
                    numberOfNumbersDividableByThree++;
                }
            }

            Console.WriteLine("Svar: " + numberOfNumbersDividableByThree);

        }


        public static void DivisibleByThree(int counter)
        {

            // Skapa en lista av tal 0,1,2,3,4,5,6

            var list = new List<int>();

            for (int i = 1; i <= counter; i++)
            {
                list.Add(i);
            }

            //{
            //    int i = 1;
            //    while (i <= counter)
            //    {
            //        i++;
            //        list.Add(i);
            //    }
            //}

            // Plocka ut de som är delbara med 3: 0,3,6

            var list2 = new List<int>();

            foreach (int item in list)
            {
                if (item % 3 == 0)
                    list2.Add(item);
            }

            Console.WriteLine(string.Join(' ', list2));
            //for (int i = 0; i < counter; i++)
            //{
            //    int numberlist = i;

            //    IList<int> numberList = new List<int>() { };
            //    foreach (var number in numberList)

            //        if (number % 3 == 0)
            //            Console.Write(number);

            //}

            //IList<int> intList = new List<int>() { i };

            //intList.Insert(1, i);// inserts 11 at 1st index: after 10.

            //foreach (var el in intList)
            //    Console.Write(el);



            //if (myNumber % 3 == 0) ;

            //int counter = 100;

            //for (int number = 0; number < counter; number++)
            //{

            //}

            //var result = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (number % 3 == 0)
            //        result.Add(number);
            //}
            //return result;
        }





    }
}



// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the result on the console.