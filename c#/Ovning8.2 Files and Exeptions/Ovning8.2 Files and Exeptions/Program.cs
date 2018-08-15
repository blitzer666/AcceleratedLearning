using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning8._2_Files_and_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a file Name: ");
           
          
            try
            {
                var userFileInput = Console.ReadLine();
                File.CreateText(userFileInput);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Not found");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

            //try
            //{
            //    //Console.Write("Enter a file Name: ");
            //    //var userFileInput = Console.ReadLine();
            //    //File.CreateText(path: userFileInput);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (writer != null)
            //    {
            //        writer.Dispose();
            //    }
            //}
