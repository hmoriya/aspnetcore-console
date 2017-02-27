using System;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;

namespace aspnetcore_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddLogging();

            foreach (var service in services)
            {
                System.Console.WriteLine(service.ServiceType.ToString());
            }
            Console.WriteLine("Hello World!");
        }
    }
}
