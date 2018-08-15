using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ovning8._3_Animals_in_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a list of animals ");
                string animalList = Console.ReadLine();
                try
                {
                    string[] animalArray = ParseAnimals (animalList);

                    Console.WriteLine("There are " + animalArray.Length + " animals in the list");
                    break;

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

            
            
        }
        private static string[] ParseAnimals(string animalsList)

        {            
            string[] animals = animalsList.Split(new[] { ',' });
            if (animalsList == "")
                throw new ArgumentException("User didnt enter any animals");

            foreach (string animal in animals)
            {
                if (animal.Length == 0)
                    throw new ArgumentException ("One of the animals is emty");
                if (animal.Length > 20)
                {
                    throw new ArgumentException("One of the animals has more than 20 letters");
                }
                    

                var x = new Regex("^[a-zåäö]+$");
                if (!x.IsMatch(animal))
                {
                    throw new ArgumentException("One of the animals contains an invalid character (only accept letters, a-z and å,ä,ö");
                }

                

            }
            return animals;

        }


}
}

//            while (true)
//            { 
//                Console.Write("Enter animal names, type done when ready: ");
//            string animalList = Console.ReadLine();
//string[] nameList = animalList.Split(',');

//Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine();

//                foreach (string name in nameList)
//                    if (animalList == "done")
//                    {
//                        Console.WriteLine(animalList);
//                    }
//                    else if () ;
//Console.Write("Enter animals: ");


//String input = Console.ReadLine();
//List<String> animalList = new List<String>();
//animalList.Add(input);

//String inputNewUser = Console.ReadLine();
//animalList.Add(inputNewUser);
//foreach (var user in animalList)
//{
//    Console.WriteLine(user);
//}


//Console.WriteLine("Enter a list of animals: ");

//List<string> animalList = new List<string>();
//string userInput = Console.ReadLine();

//string[] = userInput.Split();

//Console.WriteLine(userInput);
//try
//{
//    animalString = ParseAnimals(string animalString);
//}



//private string[] ParseAnimals(string animalsString)
//    {
//        if (userInput !=  || )

//            throw new ArgumentException("Animal string don't contain any letters");

// return animals;



