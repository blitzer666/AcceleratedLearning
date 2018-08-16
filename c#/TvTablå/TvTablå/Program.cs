using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTablå
{
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("tv-data.txt");

            var allShows = new List<Show>();

            foreach (var line in allLines)
            {
                var splittedLine = line.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];

                var show = new Show();
                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);

            }
            Header ("ALLA TITLAR");

            

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

// CHECK POINT, BEHÖVER EJ ANV METODER.

    //FÅ FRAM EN LISTA AV OBJEKT, KUNNA FILTRERA 