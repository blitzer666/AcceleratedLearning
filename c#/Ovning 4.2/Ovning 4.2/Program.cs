using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_4._2
{
    class Program
    {

        public static void Main(string[] args)
        {
            string[] peopleArray;

            while (true)
            {
                char separator = AskUserForSeparator();
                bool errorYesorNo = AskUserForErrorMessage();
                string respons = GetInputFromUser(); //viktigt att döpa logiskt                              
                peopleArray = CreateArrayOfPeople(respons, separator);
                CleanUpArray(peopleArray);


                if (PeopleArrayIsVallid(peopleArray))
                    break;
            }

            RespondToUser(peopleArray);
        }

        public static string GetInputFromUser()
        {
            Console.Write("Enter names separated by comma(e.g Maria,Peter,Lisa): ");
            string names = Console.ReadLine();
            names = names.ToUpper();
            return names;
        }

        public static string[] CreateArrayOfPeople(string response, char separator)
        {
            string[] list = response.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
           
            return list;
        }

        public static void RespondToUser(string[] peopleArray)
        {
            foreach (string name in peopleArray)


            {
                
                Console.WriteLine($"******SUPER-{name}******");

            }

        }
        private static void CleanUpArray(string[] peopleArray)
        {
            for (int i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = peopleArray[i].Trim();
            }
        }
        private static bool PeopleArrayIsVallid(string[] peopleArray)
        {
            if (peopleArray.Length == 0)
            {
                ErrorMessage("The list don't contain any names");

                return false;
            }
       
                

            

            foreach (string person in peopleArray)
            {
                if (person.Length <= 1 || person.Length >= 10)
                {
                    ErrorMessage("A person can only have 2 to 9 letters");

                    return false;
                }
            }
            return true;

        }
        private static void ErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        private static void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static char AskUserForSeparator()
        {
            
            Console.WriteLine("Which separator do you want to use (Default is comma)? ");
            char separator = char.Parse(Console.ReadLine());            
           
            return separator;
        }

                
        static bool AskUserForErrorMessage()

        {
            Console.WriteLine("Do you want to see error messages, y/n? ");
            string errorYesOrNo = Console.ReadLine().ToUpper().Trim();
            if (errorYesOrNo == "Y") return true;
            else if (errorYesOrNo == "N") return false;
            else return false;

            //else  return false;





        }





    }
}