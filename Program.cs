using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace aspnetcore_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            IServiceProvider provider = services.BuildServiceProvider();

            foreach (var service in services)
            {
                System.Console.WriteLine(service.ServiceType.ToString());
            }

            var loggerFactory = provider.GetService<ILoggerFactory>();
            var logger = loggerFactory.AddConsole(LogLevel.Debug).CreateLogger<Program>();
            logger.LogDebug("Hello ASP.NET Core World");

            
            Console.WriteLine("Hello World!");
        }
    }
}
