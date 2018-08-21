using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyaListan = new List<string>();

            Console.WriteLine(" Hej Hej");

            while (true)
            {
                string userInput = Console.ReadLine();
                string[] userInputs = userInput.Split('-');
                

                if (userInput == "exit")
                break;  
                



            }
            foreach (var item in nyaListan)
            {
                Console.WriteLine(item);
        
            }



        }
        static void MycketBraMetoden()
        {

        }
    }

}
