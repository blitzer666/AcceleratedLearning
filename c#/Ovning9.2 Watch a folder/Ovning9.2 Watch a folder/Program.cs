using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning9._2_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new FileSystemWatcher();

            x.Path = @"c:\TMP";
            x.EnableRaisingEvents = true;

            x.Created += EnFilHarLagtsTill;
            x.Renamed += EnFilHarByttNamn;
            x.Deleted += EnFilHarTagitsBort;
       

            Console.ReadKey();
        }


        private static void EnFilHarLagtsTill(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.FullPath + " har skapats!");
        }
        private static void EnFilHarByttNamn(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.FullPath + " Bytt namn!");
        }
        private static void EnFilHarTagitsBort(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.FullPath + " Tagits bort!");
        }

    }


}
