using System;

namespace PacticeCsharp
{
    public class Nr7to9
    {

        public static void ExerciceNr7(int userInput)
        {
            int number = userInput - 1;
            int result = userInput;

            while (number > 0)
            {
                result = result * number;
                number--;
            }

            Console.WriteLine(userInput + "! = " + result);
        }

        public static void ExerciceNr8()
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(1, 10);

            int counter = 0;

            while (true)
            {
                Console.Write("Guess a number between 1 and 10, enter exit when done: ");
                string userGuess = Console.ReadLine();

                counter++;

                if (userGuess.ToUpper() == "EXIT")
                {
                    break;
                }
                else if (int.Parse(userGuess) != randomNumber)
                {
                    if (counter == 4)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong, guess again!");
                    }
                }                
                else //if (int.Parse(userGuess) == randomNumber)    BEHÖVS INTE, ÖVERFLÖDIG
                {
                    Console.WriteLine("Congratulations! You guessed the right number! Number of guesses where: " + counter);
                    break;
                }
            }
        }

        public static void ExerciceNr9()
        {
            int maxNumber = 0;

            string[] arrayOfNumbersAsStrings = Console.ReadLine().Split(','); // 5,8,100,7
            int[] arrayOfNumbers = new int[arrayOfNumbersAsStrings.Length];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(arrayOfNumbersAsStrings[i]);
            }

            foreach (var number in arrayOfNumbers)
            {
                if ( number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine("Maxnumber = " + maxNumber);
        }
    }
}

/*[7] Write a program which takes a single argument from the console, computes the factorial and prints the value 
    on the console.For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

[8] Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
    If the user guesses the number, display “You won". Otherwise, display “You lost".

[9] Write a program and ask the user to enter a series of numbers separated by comma.
    Find the maximum of the numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", 
    the program should display 8 on the console.*/
