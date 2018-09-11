using System;
using System.Collections.Generic;
using System.Text;

namespace EfDemo1
{
    public class Fruit
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public decimal Price { get; set; }
        public FruitCategory Category { get; set; }

    }
}
