using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCowboy.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Cowboy Cowboy { get; set; }
        public int CowboyId { get; set; } //foreign key till Cowboy
    }
}
