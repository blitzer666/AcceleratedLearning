using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_på_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life"; ##SLASH FRAMFÖR " GÖR ATT DE GÅR ATT HA MED
            //string myString = "what if i need a\nnew line?"; ## SLASH GÖR ATT DET BLIR NY RAD "N" FÖRSVINNER OM EJ DUBBEL "N"
            //string myString = " Go to your c:\\ drive"; ## DUBBEL SLASH GÖR SÅ EJ TOLKAS SOM MELLANSLAG
            //string myString = @"Go to your c:\ drive"; ## @ GÖR SÅ ATT STUDIO IGNOR ALLA \ I RADEN

            //string myString = string.Format("{0} = {1}", "First", "Second");

            //string myString = string.Format("{0:C}", 123, 45); ## ADD CURRECY TO NUMBER
            //string myString = string.Format("{0:N}", 1234567890); ##SEPARATES LARGE NUMBER
            //string myString = string.Format("Percentage: {0:P}", .123); ## SKRIVER UT PROCENT
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 123456789012); ## DELAR UPP TELEFONNUMMER
            //string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(6, 14); ## STARTAR PÅ ANGIVET STÄLLE
            //myString = myString.Replace(" ","--"); ## ERSÄTTER MELLANRUMMEN I TEXTEN MED --
            //myString = myString.Remove(6, 14);
            /*myString = string.Format("Length before: {0} -- Length after: {1}",
                myString.Length, 
                myString.Trim().Length);
                */
            /*
        string myString = "";
        for (int i = 0; i < 100; i++) ##SKRIVA UT NUMMER UPP TILL 100 (MINNES KRÄVANDE SÄTT)
        {
            myString += "--" + i.ToString();
        }
        */

            /*StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++) ##SKRIVA UT NUMMER UPP TILL 100 (MINNES KRÄVANDE SÄTT)
            {
                myString.Append("--");
                myString.Append(i);

            }

            ## HITTA MER PÅ: msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx

            */

            string myString = "";
            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}