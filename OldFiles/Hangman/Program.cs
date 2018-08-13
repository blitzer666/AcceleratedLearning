using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static string playerName;
        static string secretWord = "banan";
        static char[] maskedWord;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        static void StartGame()
        {
            maskedWord = new char[secretWord.Length];
            for (int i = 0; i < maskedWord.Length; i++)
            {
                maskedWord[i] = '-';
            }

            AskForName();
        }

        static void AskForName()
        {
            Console.WriteLine("Ange ditt namn:");
           string input = Console.ReadLine();
        
            //Kontrollera att användaren fyllde i tillräckligt långt namn
            if (input.Length < 2)
                //Användaren har fyllt i ett namn som är mindre än två tecken långt, kör AskForName om och om igen tills namnet är 2 tecken eller
                //längre
                AskForName();
            else
                playerName = input;
        }

        static void PlayGame()
        {
            do
            {
                DisplayMaskedWord();        //Metodanrop
                AskForCharacter();          //Metodanrop
            } while (secretWord != new string(maskedWord));

            DisplayMaskedWord();
        }

        static void DisplayMaskedWord()
        {
            for (int i = 0; i < maskedWord.Length; i++)
            
                Console.Write(maskedWord[i]);  //Om det bara är en rad kan man ta bort "måsvingarna"
            
            Console.WriteLine();
                       
        }

        static void AskForCharacter()
        {
            string input;
            do
            {
                Console.WriteLine("Gissa på ett tecken i ordet");
                input = Console.ReadLine();
            } while (input.Length != 1);
            char inputchar = input[0];

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == inputchar)
                    maskedWord[i] = inputchar;
            }
        }
        static void EndGame()
        {
            Console.WriteLine("Tack för spelet " + playerName);
        }
    }
}
