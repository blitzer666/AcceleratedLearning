using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_12._2_Custom_interfaces
{

    public interface IAggressive
    {
        int Bite();
        void ShowTeeth();
    }
    
    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
    }
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



        public static void DoNiceThings(IFriendly animal)
        {
            Console.WriteLine(" DoNiceThings");
            Console.WriteLine();
            animal.Greet();
            animal.ThanksForDinner("mouse");
        }

        public static void DoMeanThings(IAggressive animal)
        {
            Console.WriteLine(" DoMeanThings");
            
            Console.WriteLine();
            animal.ShowTeeth();

            int legs = animal.Bite();
            if (legs == 1) { Console.Write("You lost one leg"); }
            if (legs == 2) { Console.Write("You lost your legs"); }
            if (legs == 3) { Console.Write("You lost your legs and one arm"); }
            if (legs == 4) { Console.Write("You lost your legs and your arms"); }
        }

    }
}




