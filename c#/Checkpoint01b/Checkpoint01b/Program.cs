using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01b
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] triangleArray;

            while (true)
            {
                string response = GetInputFromUser();
                triangleArray = CreateArrayOfTriangles(response);
                

                if (TriangleArrayIsValid(triangleArray))
                    break;
            }

            RespondToUser(triangleArray);
        }

        private static string GetInputFromUser()
        {
            Console.Write("Ange Kommando: ");
            string answer = Console.ReadLine();

            return answer;
        }

        private static string[] CreateArrayOfTriangles(string response)
        {
            string[] list = response.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            return list;
        }

        private static void RespondToUser(string[] triangleArray)
        {
            if (triangleArray.Length == 0)
            {
                WriteGreen("No people in the list");
                return;
            }

            foreach (string person in triangleArray)
            {
                Console.WriteLine("*");
            }
        }



        private static bool TriangleArrayIsValid(string[] triangleArray)
        {
            if (triangleArray.Length == 0)
            {
                ErrorMessage("The list don't contain any names");

                return false;
            }

            foreach (string person in triangleArray)
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
    }
}
