using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo1
{
    public class Basket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FruitInBasket> FruitInBaskets { get; set; }
    }
}
