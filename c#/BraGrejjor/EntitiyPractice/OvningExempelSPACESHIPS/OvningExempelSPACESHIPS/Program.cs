using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using MyProj.Data;
using SpaceshipApp.Data;
using SpaceshipApp.Domain;
using System;
using System.Linq;

namespace OvningExempelSPACESHIPS
{
    class Program
    {
        private static SpaceshipContext _context = new SpaceshipContext();

        static void Main(string[] args)
        {
            //_context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
            AddSpaceship();
            //SimpleSpaceshipQuery();
            //MoreQueries();
            //RetriveAndUpdateSpaceships();
            //RetriveAndUpdateMultipleSpaceships();
            //MultipleOperations();
            //DeletedWhileTracked();
            //DeleteMany();
        }

        private static void DeleteMany()
        {
            var spaceships = _context.Spaceships.Where(s => s.Name.Contains("o"));
            _context.Spaceships.RemoveRange(spaceships);
            _context.SaveChanges();
        }

        private static void DeletedWhileTracked()
        {
            var spaceship = _context.Spaceships.FirstOrDefault(s => s.Id == 5);
            _context.Spaceships.Remove(spaceship);
            _context.SaveChanges();
        }

        private static void MultipleOperations()
        {
            var spaceship = _context.Spaceships.FirstOrDefault();
            spaceship.Name += "Koko2";
            _context.Spaceships.Add(new Spaceship { Name = "BlaBlaShip" });
            _context.SaveChanges();
        }

        private static void RetriveAndUpdateMultipleSpaceships()
        {
            var spaceship = _context.Spaceships.ToList();
            spaceship.ForEach(s => s.Name += "Koko2");
            _context.SaveChanges();
        }

        private static void RetriveAndUpdateSpaceships()
        {
            var spaceship = _context.Spaceships.FirstOrDefault();
            spaceship.Name += "Koko1";
            _context.SaveChanges();

        }

        private static void MoreQueries()
        {
            var spaceships = _context.Spaceships.Where(s => s.Name == "Koko2").ToList();
            foreach (var spaceship in spaceships)
            {
                Console.WriteLine(spaceship.Name);
                Console.WriteLine();

            }
        }

        private static void SimpleSpaceshipQuery()
        {
            using (var context = new SpaceshipContext())
            {
                var spaceships = context.Spaceships.ToList();
                var query = context.Spaceships;
                //var spaceshipsAgain=query.ToList();
                foreach (var spaceship in query)
                {
                    Console.WriteLine(spaceship.Name);
                    Console.WriteLine();

                }

            }

        }

        private static void AddSpaceship()
        {
            var spaceship = new Spaceship { Name = "USCSS Nostromo" };
            var spaceship2 = new Spaceship { Name = "USS Sulaco" };
            var spaceship3 = new Spaceship { Name = "USCSS Patna" };
            var spaceship4 = new Spaceship { Name = "Narcissus" };

            using (var context = new SpaceshipContext())
            {
                context.Spaceships.AddRange(spaceship, spaceship2, spaceship3, spaceship4);
                context.SaveChanges();
            }

        }
    }
}
