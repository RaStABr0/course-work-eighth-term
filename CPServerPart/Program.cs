using CPServerPart.DataLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CPServerPart
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            new DataContext();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}