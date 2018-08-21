using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning12._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Paul Stanley" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Paul Stanley" };

            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarsList);

        }
        public static void DisplayArrayOfRockStars(string[] rockstars)
        {
            
            //string[] rockstarsArray = new string[3] { "Jim Morrison", "Ozzy Osborne", "Paul Stanley"};

            String[] name = new string[3]
            {"Jim Morrison", "Ozzy Osborne", "Paul Stanley"};

            for (int i = 0; i < rockstars.Length; i++) //
            {
                Console.WriteLine(rockstars[i] + ", ");
            }
            Console.WriteLine(rockstars[1]);

            foreach (var item in rockstars)
            {
              
            }

      



        }
        public static void DisplayListOfRockStars(List<string> rockstars)
        {
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Paul Stanley" };



            rockstarsList.Add("Jim Morrison");
            rockstarsList.Add("Ozzy Osbourne");
            rockstarsList.Add("Paul Stanley");

            Console.WriteLine(rockstarsList[0], rockstarsList[1], rockstarsList[2]);


            for (int i = 0; i < rockstarsList.Count; i++)
            {
               
            }
            
        }

    }
}
