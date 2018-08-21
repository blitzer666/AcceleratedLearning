using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning11._2_Work_with_list_of_Customers
{
    class Program
    {


        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("PeopleInformation.txt");


            var allCustomers = new List<Customer>();

            foreach (var line in allLines)
            {
                var splittedLine = line.Split(',');
                var customerLine = splittedLine[0];
                var firstName = splittedLine[1];
                var lastName = splittedLine[2];
                var mail = splittedLine[3];
                var gender = splittedLine[4];
                var age = splittedLine[5];

                var customer = new Customer();
                customer.FirstName = firstName;
                customer.Lastname = lastName;
                customer.MailAdress = mail;
               
                customer.Age = age;

                Customer Thomas = new Customer();

                Type _gender = Male;
                if (Enum.TryParse<Type>(gender,out _gender))
                {
                    customer.Gender = _gender;
                }

                allCustomers.Add(customer);

            }


            //allCustomers.AddRange(allCustomers);
            //Console.WriteLine("List in unsorted order: ");
            //foreach (var customer in allCustomers)
            //    Console.Write("   " +  customer.Age);


            //Console.WriteLine("List in sorted order: ");
            //foreach (var customer in allCustomers.OrderBy(x=>x.Age))
            //    Console.Write("   " + customer.Age);


            //Console.Write("{0} vvvvv {1}", "aaa", "bbb");
            //Console.WriteLine(Environment.NewLine);

            //allCustomers.Sort();
            //Console.WriteLine("List in sorted order: ");
            //foreach (var name in allCustomers)
            //    Console.Write("   {0}", name);

            Console.WriteLine();


            Header("********** CustomerNames *********");

            foreach (var fullName in allCustomers)
            {
                Console.WriteLine(fullName.FirstName + " " + fullName.Lastname);
            }
            Console.WriteLine();


            Header("********** Mailadresses *********");

            foreach (var AllMailAdresses in allCustomers)
            {
                Console.WriteLine(AllMailAdresses.MailAdress);
            }

            Header("********** Gender *********");

            foreach (var AllGEnders in allCustomers)
            {
                Console.WriteLine(AllGEnders.Gender);
            }

            Header("********** Age *********");

            foreach (var AllAges in allCustomers)
            {
                Console.WriteLine(AllAges.Age);
            }
        }
        private static void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ResetColor();

        }
    }
}













//    var allLines = File.ReadAllLines("PeopleInformation.txt");

//    var allCustomers = new List<Customer>();

//    foreach (var line in allLines)
//    {



//        var splittedLine = line.Split('*');
//        var name = splittedLine[0];
//        var lastName = splittedLine[1];
//        var mailAdress = splittedLine[2];
//        var gender = splittedLine[3];
//        var age = splittedLine[4];

//        var show = new Customer();
//        show.Title = title;
//        show.Channel = channel;
//        show.StartAt = TimeSpan.Parse(time);

//        allShows.Add(show);

//    }


