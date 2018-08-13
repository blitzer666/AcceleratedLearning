using System;

namespace Ovning117Myndig
{
    class Program
    {

        static bool AgeCheck(int age)
        {
            if (age < 18)
            {
                return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.Write("Är du myndig? Ange din ålder: ");
            string str = Console.ReadLine();
            int age = Convert.ToInt32(str);
            if (AgeCheck(age))
            {
                Console.WriteLine("Du är myndig");
            }
            else
            {
                Console.WriteLine("Du är omyndig");
            }
        }
    }
}
        
        
      
                           


