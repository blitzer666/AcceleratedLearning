using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_list_of_complex_type
{
    class Program
    {
        static void Main(string[] args)
        {

Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,

            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,

            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,

            };
            Customer customer4 = new Customer();


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name); // Ändrat från Salary
            }

            listCustomers.Sort();
            listCustomers.Reverse();
            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name); // Ändrat från Salary
            }
            Comparison<Customer>

            SortByName sortByName = new SortByName();
            listCustomers.Sort();
            Console.WriteLine("Sorting by Name");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer : IComparable<Customer> //Måste lägga till IComparable för att kunna sorta...
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {


            return this.Name.CompareTo(other.Name); //// Ändrat från Salary till Name, även ändrat länre upp..
            //return this.Salary.CompareTo(other.Salary); //Gör samma som nedan men mindre kod...
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else return 0;
        }

    }
}
