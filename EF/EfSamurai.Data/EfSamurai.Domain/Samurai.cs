using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    // Principal (parent) entitet till SecretIdentity
    // Principal (parent) entitet till Quote

    public class Samurai
    {
        public int Id { get; set; } // Primärnyckeln används av SecretIdentity
        public string Name { get; set; }
        public HairStyle? HairStyle { get; set; }

        public List<Quote> Quotes { get; set; }
        public SecretIdentity SecretIdentity { get; set; }

        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
