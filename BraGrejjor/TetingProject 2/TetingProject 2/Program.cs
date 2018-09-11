using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TetingProject2
{
   public class Program
    {
        static DataAccess dacc = new DataAccess();
        static void Main(string[] args)
        {
            new App().MenuChoice();
            Console.ReadKey();

        }
    }
}
