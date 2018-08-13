using System;

namespace Ovning_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            string result1 = "You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!";
            string result2 = string.Format("You entered three fruits: {0}, {1}, {2}", fruit1, fruit2, fruit3);          //fruit1, fruit2, fruit3);
            string result3 = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}";





            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            //string fruits = "fruit1" + "fruit2" + "fruit3");

            //string result2 = string.Format(result 2 = "fruit1, fruit2, fruit3 {0} fruit2 {1}fruit3 {2}");
            //"fruit1: {0} fruit2" {1} fruit3 { 2}

            //string result3 = 







        }
    }
}
