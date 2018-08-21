using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_12._2_Custom_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            DoMeanThings(buddy);

            DoNiceThings(musse);

        }

    }
    public class Cat : IFriendly
    {
        public void DoNiceThings()
        {
        }

    }



    public class Dog : IAggressive, IFriendly
    {
        public void DoNiceThings()
        {
        }
        public void DoMeanThings()
        {

        }
    }

    public interface IAggressive
    {
    }
    public interface IFriendly
    {
    }
}

  

