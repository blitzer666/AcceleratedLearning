using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempel734
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 0; //Här vill ingen bada

            //Kontrollera med användaren om det finns vatten
            Console.WriteLine("Finns det vatten? j/n");
            string answer = Console.ReadLine();

            //Kontrollera med användaren hur varmt det är
            Console.WriteLine("Hur varmt är det?");
            temperature = Convert.ToInt32(Console.ReadLine());

            //Om det finns vatten och är varmt nog så kan vi bada

            if (answer == "j" && temperature > 17 && temperature < 40)
            {
                Console.WriteLine("Det går att bada! Vill du hoppa i? j/n");
                answer = Console.ReadLine();
                if (answer == "j")
                {
                    Console.WriteLine("Du hoppar i plurret. Det är jätteskönt!");
                }
                else
                {
                    Console.WriteLine("Du bestämmer dig för att vara en badkruka");
                }
            }
            else
            {
                Console.WriteLine("Det går inte att bada");
            }
        }
    }
}
    

