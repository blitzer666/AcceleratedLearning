using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_4._1
{
    class Program
    {




        //public static void RespondToUser()
        //{

        //    foreach (string name in nameList)
        //    {

        //        Console.WriteLine($"******SUPER-{name}******");

        //    }


        //}
        public static void Main(string[] args)
        {

            var xxxxx = GetInputFromUser();
            var yyyyyy = CreateArrayOfPeople(xxxxx);

            RespondToUser(yyyyyy);




            //RespondToUser();

            //Console.WriteLine("Enter names separated by comma(e.g Maria,Peter,Lisa: ");
            //string names = Console.ReadLine();
            //names = names.ToUpper();
            //string[] nameList = names.Split(',');



            //foreach (string name in nameList)
            //{

            //    Console.WriteLine($"******SUPER-{name}******");

            //}

        }

        public static string GetInputFromUser()
        {
            Console.WriteLine("Enter names separated by comma(e.g Maria,Peter,Lisa: ");
            string names = Console.ReadLine();
            names = names.ToUpper();
            return names;
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
