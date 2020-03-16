using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkerServiceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSystemd() // Support Linux
                .UseWindowsService() // Support Windows Services
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();

                });
    }
}
