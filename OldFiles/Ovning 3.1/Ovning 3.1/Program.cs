using System;

namespace Ovning_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When did you go to bed yesterday? ");
            int .Parse(Console.ReadLine());
            Console.WriteLine("When did you wake up?" );
            DateTime wakeUp = Convert.ToDateTime(Console.ReadLine());

            
            TimeSpan span = goToBed.Subtract(wakeUp);

            Console.WriteLine("Time Difference (hours): " + span.Hours );
          

            
            
            



        }
    }
}
