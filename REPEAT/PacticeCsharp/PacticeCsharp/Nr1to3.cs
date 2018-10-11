using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeCsharp
{
    public class Nr1to3
    {
        public static void NumberBetween1and10()

        {
            Console.WriteLine("Övning1");


            Console.Write("Enter a number between 1 and 10: ");
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput <= 10 && userInput >0)
                {
                    Console.WriteLine("Valid");
                    break;
                }

                else
                {
                    Console.WriteLine("invalid enter a number between 1 and 10");
                    
                }

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void MaximumOf2Numbers()
        {
            int maxNumber;

            Console.WriteLine("Övning2");

            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());


            

            if (x > y)
            {
                maxNumber = x;
            }
            else if (y > x)
            {
                maxNumber = y;
            }
            else
            {
                maxNumber = y;
            }


            Console.WriteLine("The maximum number of " + x + " and " + y + " is: " + maxNumber);


            Console.WriteLine();
            Console.ReadLine();
        }



        public static void IsLandscapeorPortrait()
        {
            Console.WriteLine("Övning3");

            Console.WriteLine("Enter the width of the image: ");
            int widthOfImage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the heigth of the image");
            int heigtOfImage = int.Parse(Console.ReadLine());

            if (widthOfImage > heigtOfImage)
                Console.WriteLine("The image is landscape");
            else if (heigtOfImage > widthOfImage)
                Console.WriteLine("The image is portrait");
            else
                Console.WriteLine("The image is square-shaped");
        }
    }

}

