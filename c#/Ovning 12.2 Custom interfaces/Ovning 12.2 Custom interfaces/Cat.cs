using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_12._2_Custom_interfaces
{ 
public class Cat : IFriendly
{
   

    public string Name { get; }

    public Cat(string name)
    {
        Name = name;
    }

    public void Greet()
    {
        Console.Write ($" The cat {Name} says miao");
    }

    public void ThanksForDinner(string meal)
    {
        Console.Write($" The cat {Name} thank you for the {meal}");
    }
}
}