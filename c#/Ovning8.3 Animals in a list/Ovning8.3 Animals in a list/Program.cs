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
                    string[] animalArray = ParseAnimals(animalList);

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
                    throw new ArgumentException("One of the animals is emty");
                if (animal.Length > 20)
                {
                    throw new ArgumentException("One of the animals has more than 20 letters");
                }


                var x = new Regex("^[a-zåäö]+$", RegexOptions.IgnoreCase); // ^ betyder början, $ är avslut (regex måste läggas till)
                if (!x.IsMatch(animal))
                {
                    throw new ArgumentException("One of the animals contains an invalid character (only accept letters, a-z and å,ä,ö");
                }



            }
            return animals;

        }
    }


}



