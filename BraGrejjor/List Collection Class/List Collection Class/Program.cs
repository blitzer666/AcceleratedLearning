using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Collection_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key = " + kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }


            //List<Customer> listCustomers = new List<Customer>();
            //listCustomers.Add(customer1);
            //listCustomers.Add(customer2);
            //listCustomers.Add(customer3);

            //listCustomers.ToArray();

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}


            //---------------------------------------------------------------------------------------------------------------------------------------
            //Customer[] customerArray = new Customer[3];
            //customerArray[0] = customer1;
            //customerArray[1] = customer2;
            //customerArray[2] = customer3;

            //List<Customer> listCustomer = customerArray.ToList();

            //foreach (Customer c in listCustomer)
            //{
            //    Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------


            //List<Customer> listCustomers = new List<Customer>();
            //listCustomers.Add(customer1);
            //listCustomers.Add(customer2);
            //listCustomers.Add(customer3);

            //int index = listCustomers.FindLastIndex(2, cust => cust.Salary > 5000);
            //Console.WriteLine("Index = " + index);

            //int index = listCustomers.FindIndex(2, cust => cust.Salary > 5000);
            //Console.WriteLine("Index = " + index);


            //List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 5000);

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}
            //---------------------------------------------------------------------------------------------------------------------------------------

            //Customer c = listCustomers.FindLast(cust => cust.Salary > 5000);
            //Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            //Customer c = listCustomers.Find(cust => cust.Salary > 5000);
            //Console.WriteLine("ID {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
        }

        //if (listCustomers.Contains(customer3))
        //    if (listCustomers.Exists(cust => cust.Name.StartsWith("P")))
        //    {
        //        Console.WriteLine("Customer3 object exists in the list");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Customer3 object does not exists in the list");
        //    }
        //}

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

        }
    }
}
