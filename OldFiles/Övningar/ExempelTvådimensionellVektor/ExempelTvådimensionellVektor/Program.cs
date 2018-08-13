using System;

namespace ExempelTvådimensionellVektor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameboard = new int[6, 4];
            gameboard[0, 0] = 1;
            gameboard[0, 1] = 1;
            gameboard[0, 2] = 1;
            gameboard[0, 3] = 0;
            gameboard[1, 0] = 0;
            gameboard[1, 1] = 0;

            //Eller förenlat sätt:
            //int[,] gameboard = new int[,]
            //{ { 1, 0,0,1,0,0},
            //    { 1,0,0,1,0,0},
            //    { 1,0,0,0,0,0},
            //    { 0,0,1,1,1,1}
            //};








        }
    }
}
