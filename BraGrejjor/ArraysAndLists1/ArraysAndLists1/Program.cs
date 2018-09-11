using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Multidimensional arrays

            CreateGrid();

            Console.ReadKey();

        }
        public static void CreateGrid()
        {

            int width = 20;
            int height = 20;

            // int width = 5;
            //int height = 5;

            int[,] grid = new int[width, height];

            //int[,] grid = new int[5, 5];                       // ett kommatecken betyder att det är en twodimensional... två kommatecken betyder threedimensional  osv...
            //grid[2, 3] = 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine(); //måste vara en radbrytning annars skrivs allt ut på samma rad...
            }



            //*************************************************************************************************************************************************
            //*************************************************************************************************************************************************

            //LISTS ! ! !  (Använd List om man inte vet i förhand hur många element som ska finnas, 
            //Arrays är att föredra om man vet hur många element som ska finnas. Arrays är snabbare....
            // raden "using System.Collections.Generic;" måste alltid finnas med längst upp.

            //List<int> numbers = new List<int>();

            //numbers.Add(13); // rad 0
            //numbers.Add(4); // rad 1
            //numbers.Add(8); // rad 2

            //Console.WriteLine(numbers[1]);  Skriva ut värde från list.

            //for (int i = 0; i < numbers.Count; i++) //Använd INTE .Length (används Array! ,  Använd .Count istället
            //{
            //    Console.Write(numbers [i] + ", ");
            //}

            //Console.WriteLine();

            //numbers.RemoveAt(0); // Tar bort värde på specifik rad, i detta fall rad 0 (siffran 13).
            //numbers.Remove(4); // Söker efter värdet 4 och tar bort det, KOM IHÅG att den endast tar bort 
            // första värdet den stöter på och sen lämnar allt annat därefter...

            //for (int i = 0; i < numbers.Count; i++) //Använd INTE .Length (används Array! ,  Använd .Count istället
            //{
            //    Console.Write(numbers [i] + ", ");
            //}



            //*************************************************************************************************************************************************
            //*************************************************************************************************************************************************
            //ARRAYS ! ! !

            //int amountOfNumbers = 5;
            //int[] numbers = new int[ammountOfNumbers]; (istället för int[] numbers = new int[5];)

            //int[] numbers = new int[5];// Ange alltid hur många värden arrayen ska innehålla innanför [] Alltid ett "fast värde"
            //numbers[0] = 12;
            //numbers[1] = 3;
            //numbers[2] = 5;

            //String[] names = new string[3]
            //{"Lisa", "Emma", "Ada"};                  //ALLTID avsluta med ; efter stringlista...

            //for (int i = 0; i < numbers.Length; i++) //
            //{
            //    Console.WriteLine(numbers [i] + ", ");
            //}
            //Console.WriteLine(numbers[1]); //Skriver ut element [1] som innehåller "3"



            //foreach (int number in numbers) //För varje int i numbers, skapar variabel number som används i write nedan
            //{
            //    Console.Write(number + ", ");
            //}

            //foreach (string name in names)
            //{
            //    Console.Write(name + ", ");
            //}


            Console.ReadKey();

        }

    }
}
