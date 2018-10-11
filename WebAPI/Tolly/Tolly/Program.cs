using System.IO;
using System.Text;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Tolly
{
    public class Program
    {
        public static void Main(string[] args)

        {
            string text = File.ReadAllText(@"c:\file.txt", Encoding.UTF8);


            //String file1 = "C:\Project\AcceleratedLearning\WebAPI\Tolly\Tolly\wwwroot\file1.txt";
            //CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
