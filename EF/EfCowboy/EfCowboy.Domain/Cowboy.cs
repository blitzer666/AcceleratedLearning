using System;
using System.Collections.Generic;

namespace EfCowboy.Domain
{
    public class Cowboy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Charm { get; set; }
        public List<Quote> Quotes { get; set; }
        public SecretIdentity SecretIdentity { get; set; }

    }
}
