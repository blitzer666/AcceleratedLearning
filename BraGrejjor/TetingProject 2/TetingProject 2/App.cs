using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TetingProject2
{
    public class App
    {
        static DataAccess dacc = new DataAccess();

        public void MenuChoice()
        {
            Console.WriteLine("Wel Come To Database menu\n");
            Console.WriteLine("enter a to " + "search detail in the tables");
            Console.WriteLine("enter b to " + "get all detain in database tables");
            Console.WriteLine("enter c to " + "update database");
            Console.WriteLine("enter d to " + "insert data in to database");
            ConsoleKey command = Console.ReadKey().Key;


            switch (command)
            {
                //case ConsoleKey.A: SearchAllDetailInDataBaseTables(); break;
                case ConsoleKey.B: PrintAllData(); break;
                    //case ConsoleKey.C: PrintUpdateTables(); break;
                    //case ConsoleKey.D: InsertDataInToTables(); break;

            }



            Console.WriteLine();

        }
        public void PrintAllData()
        {
            List<Sql> allData = dacc.GetOrderDates();
            Console.WriteLine("\n");
            Console.WriteLine("OrderID".PadRight(30) + "CustomerName".PadRight(30) + "Orderdate");
            foreach (var item in allData)
            {

                Console.WriteLine(item.orderID + item.CustomerName.PadRight(30) + item.orderdate);
            }
            //Console.ReadLine();
        }
    }
}