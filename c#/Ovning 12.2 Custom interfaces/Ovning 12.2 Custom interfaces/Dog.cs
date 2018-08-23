using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_12._2_Custom_interfaces
{
    public class Dog : IFriendly, IAggressive
    {
       

        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }

        public int Bite()
        {
            Console.Write($" The dog {Name} bit you!");
            return new Random().Next(4) + 1;
        }

        public void ShowTeeth()
        {
            Console.Write($" The dog {Name} shows his teeth");
        }

        public void Greet()
        {
            Console.Write($"The dog {Name} says woof");
        }

        public void ThanksForDinner(string meal)
        {
            Console.Write($" The dog {Name} thank you for the {meal}");
        }
    }
}