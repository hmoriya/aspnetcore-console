using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace console_serilog_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sercices = new ServiceCollection();
            sercices.AddLogging();
            var provider = sercices.BuildServiceProvider();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.LiterateConsole()
                .CreateLogger();

            var factory = provider.GetService<ILoggerFactory>();
            factory.AddSerilog();
            
            
            
        }
    }
}
