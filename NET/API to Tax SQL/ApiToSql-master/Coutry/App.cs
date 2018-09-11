using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Coutry
{
    public class App
    {
        internal void Menu()
        {
            Console.WriteLine("\n\tWellcome To Database menu\n",Color.DeepPink);
            Console.WriteLine("\tenter A " + "Search Detail in the Colums");
            Console.WriteLine("\tenter B " + "Get all detail in Database Tables");
            Console.WriteLine("\tenter C " + "Update singel colums in the Database");
            Console.WriteLine("\tenter D " + "Insert data in to Database");
            Console.WriteLine("\tenter E " + "Exit");
            ConsoleKey command = Console.ReadKey().Key;

            FormuleringSqlData sqlData= new FormuleringSqlData();

            Console.Clear();
            switch (command)

             
            {
                
                case ConsoleKey.A: sqlData.PrintingDataInColums(); break;
                case ConsoleKey.B: sqlData.PrintAllDataInDataBase(); break;
                case ConsoleKey.C: sqlData.UpDateSingelColumsInDataBase(); break;
                case ConsoleKey.D: sqlData.AskingForInsertDetail(); break;
                case ConsoleKey.E: Exit(); break;
                default:
                    Console.WriteLine("Invalid selection. Please select A, B, C, D or E.");
                    Menu();
                    break;
                    
            }
            


        }

        private void Exit()
        {
            Console.WriteLine(@"                          
                            @@@@@@@@@@                          
                           @@@@@@@@@@@@@@@                         
                           @@           @@                         
                         @@@@@         ;@@@#                       
                       @@@@@@@`        @@@@@@@                     
                      ,@@@: @@@       +@@ :@@@.                    
                      @@@   ,@@,      @@#   @@#                    
                      #@@+    @@     @@   ;@@;                    
                       @@@#             +@@@                     
                          @@@@.;+###+;.@@@@                        
                           @@@@@@@@@@@@@@#                         
                           @@@@@@@@@@@@@@@                         
                         `@@@;         ;@@@,                       
                        ,@@@             @@@;                      
                      ,@@@                  @@@;                   
                    @@@`         :@@          @@@                
                  ,@@'           :@@            :@@;               
                 @@@          @@@@@@@@@          @@@               
                @@@          @@@@@@@@@@@          @@@              
               `@@,         #@@+     +@@@         .@@.             
               @@@          @@#       +@@          @@@             
              ,@@           @@@                     @@,            
              @@@           +@@@@`@@                 @@@            
             @@,                 @@@@@@`B            ,@@           
            ,@@             @@,       @@@O             @@,          
            @@@             @@:       +@@R             @@@          
            @@;             @@@      `@@@I             ;@@          
            @@`             `@@@@@@@@@@@S               @@          
            @@               .@@@@@@@@@                @@          
           .@@                 `;#@@;                  @@.         
           ,@@                   '@@                   @@:         
           ,@@                   '@@                   @@,   
            '@@                           .@#         @@+          
             @@@                        ;@@@@        @@@           
             .@@@                    ;@@@@@@`       @@@.           
              ;@@@#              ;@@@@@@@@        #@@@;            
               .@@@@@+`  `,'@@@@@@@@@@@,      .+@@@@@.             
                 #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#               
                     ,@@@@@@@@@@@@@@@@@@@@@@@@@@,");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}
