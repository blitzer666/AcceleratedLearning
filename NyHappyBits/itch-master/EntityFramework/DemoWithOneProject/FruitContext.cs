﻿
using Microsoft.EntityFrameworkCore;

namespace DemoWithOneProject
{
    public class FruitContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }

        // Går in här vid t.ex EnsureCreated (men inte när context skapas)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = DemoWithOneProject;");
            }

        }

    }
}