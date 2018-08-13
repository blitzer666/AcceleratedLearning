using System;

namespace ExempelWhileochForLoop
{
    class Program
    {
        static void Main(string[] args)

        {
            //MULTIDIMESIONELL VEKTOR

            //Skapa en tvådimesionell vektor som är 6x4 stor.
            int[,] gameboard = new int[,]
                {{1,0,0,2,0,0},
                {1,0,0,1,0,0 },
                {1,0,0,0,0,0 },
                {0,0,1,1,1,1 } };
            //Den yttre for-loopen går igenom vektorn vågrätt
            for (int i = 0; i < gameboard.GetLength(0); i++)
            {
                //Skriv ut lite snygga grejer:
                Console.WriteLine("----------------------------------");
                Console.Write("| ");
                //Den inre for-loopen går igenomvektorn lodrätt:
                for (int j = 0; j < gameboard.GetLength(1); j++)
                {
                    //Skriv ut elementet på just denna position i vektorn:
                    Console.Write(gameboard[i, j] + " | ");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("----------------------------------");


            //WHILE-LOOPEN
            //{
            //    int i = 0;
            //    while(i<20)
            //    { Console.WriteLine(i);
            //        i++;

            //    }

            //FOR-LOOPEN
            //{
            //    for (int i = 0; i<5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            // {
            //TAG EMOT VEKTOR FRÅN ANVÄNDAREN
            //Console.Write("Ange antal temperaturer som du har mätt upp: ");
            //string str = Console.ReadLine();
            //int size = Convert.ToInt32(str);

            ////Skapa vektor
            //int[] temperatur = new int[size];

            ////Tilldela vektorn element olika värden via for-loop
            //for (int i = 0; i < temperatur.Length; i++)
            //{
            //    Console.Write("Ange temperatur " + i + ": ");
            //    str = Console.ReadLine(); //återanvänd variabel str!
            //    int element = Convert.ToInt32(str);
            //    //Lägg in värdet i vektorn på index i 
            //    temperatur[i] = element;
            //}
            ////Räkna ut summan i alla element:
            //int sum = 0;
            //for (int i = 0; i < temperatur.Length; i++)
            //    sum = sum + temperatur[i];
            //Console.WriteLine("Medeltemperaturen är: " +sum / temperatur.Length);


        }

    }
}
