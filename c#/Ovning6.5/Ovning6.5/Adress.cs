using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ovning6._5
{
    class Adress
    {
        public String Street { get; set; }
        public int StreetNr { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }



        public void SetZipCode(string value)

        {
            if (Regex.IsMatch(value, @"\d\d\d\s\d\d$"))

                ZipCode = value;
        
        }




        public string GetFullAdress()
        {
            return Street + StreetNr;
        }

    }

}
