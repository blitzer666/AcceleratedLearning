using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo1
{
    public class FruitInBasket
    {
        public int FruitId { get; set; }
        public Fruit Fruit { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
