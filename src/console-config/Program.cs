using System;
using Microsoft.Extensions.Configuration;

namespace console_config
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            System.Console.WriteLine(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
