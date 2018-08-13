using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningxx
{
    class Program
    {
        class Product
        {
            public decimal Price { get; set; }
            public decimal GetVat()
            {
                return Price *0.25M;

            }
            public decimal Vat { get; set; }
            public decimal Totalprice { get; set; }
        }
        static void Main(string[] args)
        {
            var telefon = new Product();
            telefon.Price = 1200;
            telefon.Vat = 300;
            telefon.Totalprice = 1500;


        }
    }
}
