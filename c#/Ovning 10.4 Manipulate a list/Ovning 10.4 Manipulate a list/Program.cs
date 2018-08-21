using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_10._4_Manipulate_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameInput = new List<string>();

            Console.Write("Enter a name, type exit when your done: ");
            string input = Console.ReadLine();
            nameInput.Add(input);


            while (input != "")
            {
                Console.Write("Enter a name, type exit when your done: ");
                input = Console.ReadLine();
                nameInput.Add(input);
            }

            if (input == "")
            {
                foreach (string value in nameInput)
                {
                    Console.WriteLine("Name " + value);
                }
                Console.ReadLine();
            }
                    

        }
    }
}


//    string[] peopleArray;

//    while (true)
//    {
//        Console.Write("Enter a name, type quit when done: ");
//        string response = GetInputFromUser();
//        peopleArray = CreateArrayOfPeople(response);


//        if (response == "quit")
//            break;
//    }

//    RespondToUser(peopleArray);
//}

//private static string GetInputFromUser()
//{

//    string answer = Console.ReadLine();

//    return answer;

//}

//private static string[] CreateArrayOfPeople(string response)
//{
//    string[] list = response.Split(new[] { ' ' });

//    return list;
//}

//private static void RespondToUser(string[] peopleArray)
//{
//    if (peopleArray.Length == 0)
//    {
//        WriteGreen("No people in the list");
//        return;
//    }

//    foreach (string person in peopleArray)
//    {
//        Console.WriteLine();

//        //WriteGreen($"***SUPER-{person.ToUpper()}***");
//    }
//}

////private static void CleanUpArray(string[] peopleArray)
////{
////    for (var i = 0; i < peopleArray.Length; i++)
////    {
////        peopleArray[i] = peopleArray[i].Trim();
////    }
////}

//private static bool PeopleArrayIsValid(string[] peopleArray)
//{
//    if (peopleArray.Length == 0)
//    {
//        ErrorMessage("The list don't contain any names");

//        return false;
//    }

//    foreach (string person in peopleArray)
//    {
//        if (person.Length <= 1 || person.Length >= 10)
//        {
//            ErrorMessage("A person can only have 2 to 9 letters");

//            return false;
//        }
//    }
//    return true;
//}

//private static void ErrorMessage(string text)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(text);
//    Console.ForegroundColor = ConsoleColor.White;
//}

//private static void WriteGreen(string text)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(text);
//    Console.ForegroundColor = ConsoleColor.White;
