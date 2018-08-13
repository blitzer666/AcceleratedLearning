using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4._3
{
    class Program
    {

        public static void Main(string[] args)
        {

            var xxxxx = GetInputFromUser();
            var yyyyyy = CreateArrayOfPeople(xxxxx);

            RespondToUser(yyyyyy);
        }
        public static string GetInputFromUser()
        {
            Console.WriteLine("Enter names separated by comma(e.g Maria,Peter,Lisa: ");
            string names = Console.ReadLine();
            names = names.ToUpper();
            return names;
        }

        public static string[] ValidateUserInput()
        {
            string[] values = { null, String.Empty, "True", "False",
                          "true", "false", "    true    ",
                           "TrUe", "fAlSe", "fa lse", "0",
                          "1", "-1", "string" };
            foreach (var value in values)
            try{
                }
                catch

        }
        
        public static string[] CreateArrayOfPeople(string response)
            
        {
            string[] nameList = response.Split(',');
            return nameList;
        }

        public static void RespondToUser(string[] peopleArray)
        {
            foreach (string name in peopleArray)


            {

                Console.WriteLine($"******SUPER-{name}******");

            }
            

        }
    }
}
