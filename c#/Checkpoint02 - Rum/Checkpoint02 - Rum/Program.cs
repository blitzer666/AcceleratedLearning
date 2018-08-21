using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Checkpoint02___Rum
{
    class Program
    {

        static void Main(string[] args)
        {

            //string userInput = Console.ReadLine();
            //string[] userInputs = userInput.Split('|');



            Console.Write("Enter Rooms: ");
            string listOfRooms = Console.ReadLine();

            // Create list

            string[] list = listOfRooms.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


            //var userInput = new List<allRooms>();


            foreach (var line in listOfRooms)
            {
                var splittedLine = line.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];

                Show show = new Show();
                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);

            }

            Header("ALLA TITLAR");



            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }
            Header("ALLA KANALER");
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }

            var laterThan21 = new List<Show>();
            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }
            }
            Header("Program som börjar senare än 21\n"); // Utan Linq

            foreach (var show in laterThan21)
            {
                Console.WriteLine(show.Channel + " " + show.StartAt + " " + show.Title);
            }
            Header("Program som börjar senare än 21 med Linq\n");

            var resultat = allShows.Where(x => x.StartAt.Hours >= 21);   //Med Linq
            foreach (var show in resultat)
            {


                WriteInfoAboutShow(show);

            }


            allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt);


        }

        private static void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ResetColor();

        }

        private static void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine(show.Channel.PadRight(4) + show.StartAt + " " + show.Title);
        }


    }
}

























//        {
//            Console.Write("Enter Rooms: ");
//            //string listRooms = Console.ReadLine();

//            List<Room> listRooms = new List<Room>();
//            Room.name

//        }
//    }
//}

























//            // Create list

//            string[] list = listOfRooms?.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

//            if (list == null || list.Length == 0)
//            {
//                Console.WriteLine("No people in the list");
//            }
//            else
//            {
//                foreach (string room in list)
//                {
//                    Console.WriteLine(room);
//                }
//            }

//        }

//        //var allRooms = new List<Room>();



//    }
//}


//            //foreach (var separateRoom in allRooms)
//            //{


//                //string[] splittedLine = separateRoom.Split('|');
//                //string name = splittedLine[0];
//                //int m2 = splittedLine[1];
//                //string m2Number = splittedLine[2];

//            //    var room = new Room();

//            //     room.name = name;
//            //    show.Channel = channel;
//            //    show.StartAt = TimeSpan.Parse(time);

//            //    allRooms.Add(show);
//            //}
//            //{
//            //    string answer = "";

//            //    var nyaListan = new List<string>();

//            //    Console.WriteLine(" Hej Hej");

//            //    while (true)
//            //    {
//            //        Console.WriteLine("Ange namn på rum: ");
//            //        string userInput = Console.ReadLine();
//            //        string[] userInputs = userInput.Split('|');

//            //        if (string.IsNullOrWhiteSpace(answer))
//            //        {
//            //            break;
//            //        }
//            //        answer = answer.Trim();

//            //        if (!ValidInput(answer))
//            //        {
//            //            ch.ErrorMessage("Invalid input");
//            //            continue;
//            //        }
//            //        while (true)
//            //        {
//            //            string userInput = Console.ReadLine();
//            //            string[] userInputs = userInput.Split('-');


//            //            if (userInput == "exit")
//            //                break;




//            //        }
//            //        foreach (var item in nyaListan)
//            //        {
//            //            Console.WriteLine(item);

//            //        }
//            //    }

