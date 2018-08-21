using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args) //Classes
        {

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };
            List<Customer> customers = new List<Customer>(2); //KAn bara adda av typen customers...om inte Ärvda klasser...
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, customer3); //Nu kommer custemor 3 vara på två ställen, både på första och sista..

            Console.WriteLine(customers.IndexOf(customer3, 1, 3));

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine(c.ID);
            //}

            SavingsCustomer sc = new SavingsCustomer();
            customers.Add(sc);

            //foreach (Customer c in customers)
            //for (int i = 0; i < customers.Count; i++)
            //{

            //    Customer c = customers[i];
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary); // c kan heta vad som helst....  
            //}                    


        }
        public class SavingsCustomer: Customer
        {

        }
    }
}
