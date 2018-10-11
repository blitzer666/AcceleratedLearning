using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsCsharp
{
    class Program
    {
        public static string Remove_char(string s)
        {
            int index = 0;
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '"')
                {
                    result[index++] = s[i];
                }
            }
            return new string(result, 0, index);
        }
        //public static string Remove_char(string s)


        //// Our example string array.
        //string[] items = new string[]
        //{
        //"Freeway"           
        //};



        //// Loop and call TrimEnd.
        //foreach (string item in items)
        //{
        //    //string trimmed = item.TrimEnd('?', '.', ',');

        //    //string trimmed1 = item.TrimStart('F'); 
        //    string trimmed = item.TrimStart('F')

        //    //string trimmed = trimmed1 + trimmed2;

        //    //Console.WriteLine(item);
        //    //Console.WriteLine(trimmed);
        //    Console.WriteLine(trimmed);
        //}
        //Console.ReadLine();
    }
    
}