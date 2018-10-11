using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeCsharp
{
    public class Nr10
    {
        public static void ExerciceNr10()
        {
            List<string> nameInput = new List<string>();

            int inputCounter = 0;

            while (true)
            {
                Console.WriteLine("Enter name :");
                string input = Console.ReadLine();

                if (input == "")
                    break;

                nameInput.Add(input);
                inputCounter++;
            }

            if (inputCounter == 1)
            {
                Console.WriteLine(nameInput[0] + " Likes your post");
            }
            else if (inputCounter == 2)
            {
                Console.WriteLine(nameInput[0] + " and " + nameInput[1] + " Likes your post");
            }
            else if (inputCounter > 2)
            {
                int Sum = inputCounter -2;
                Console.WriteLine(nameInput[0] + ", " + nameInput[1] + " and " + Sum + " others likes your post");
            }

        }
    }
}


//Write a program and continuously ask the user to enter different names, until the
//user presses Enter(without supplying a name). Depending on the number of names provided,
//display a message based on the above pattern.

//Beroende på antal namn som matas in svara på tre olika sätt:

//* Kalle, Lisa and 5 others like your post
//* Kalle and Lisa like your post
//* Kalle likes your post.
