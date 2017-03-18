using System;
using Serilog;

namespace console_serilog_async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Async(a => a.RollingFile("logs/asynclog-{Date}.txt"))
                // Other logger configuration
                .CreateLogger();

            Log.Information("This will be written to disk on the worker thread");

            // At application shutdown
            Log.CloseAndFlush();
        }
    }
}
