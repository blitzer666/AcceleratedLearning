using EfCowboy.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfCowboy.Data
{
    public class CowboyContext : DbContext
    {
       
        public DbSet<Cowboy> Cowboys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EfCowboy;");
        }
    }
}
