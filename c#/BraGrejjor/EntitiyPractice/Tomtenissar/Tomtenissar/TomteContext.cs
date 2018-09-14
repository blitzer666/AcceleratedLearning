using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomtenissar
{
    public class TomteContext : DbContext
    {
        public DbSet<Tomtar> Tomte { get; set; }
        public DbSet<Battle> Battle { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EfTomtar; Trusted_Connection = True; ");
        }



    }
}
