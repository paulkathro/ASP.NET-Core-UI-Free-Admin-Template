using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CoreUI_Free_Bootstrap_Admin
{
  public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                   webBuilder.UseStartup<Startup>();
                 });
  }
}
