using Common.Services;
using System;

namespace OnlineStore.consolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringstring = new StringService();
            string original = "Det var en gamal gubbe";

            string answer =  CutString(original, 5);

            Console.WriteLine(answer);
        }


        static string CutString(string s, int cutlength)
        {
            return s.Substring(0, cutlength) + "...";
        }
    }
}
