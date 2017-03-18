using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace console_log
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();
            factory
                .AddConsole()
                .AddDebug();

            var logger = factory.CreateLogger<Program>();
            logger.LogError("test");
            logger.LogInformation()

            Console.ReadLine();


        }
    }
}
