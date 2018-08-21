using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning11._2_Work_with_list_of_Customers
{
    public static class Customer
    {



        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string MailAdress { get; set; }
        public Type Gender { get; set; }
        public string Age { get; set; }

        public enum Type
        {
            Male,
            Female,
            Other
        }

    }

}
