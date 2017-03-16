using System;
using Microsoft.Extensions.DependencyInjection;

namespace console_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<ParentService>();
            services.AddTransient<ChildService>();

            var provider = services.BuildServiceProvider();
            using (var service1 = provider.GetService<ParentService>())
            {
            // so something with the class
            }
        }
    }

    public class ParentService : IDisposable
    {
        private ChildService _child;
        public ParentService(ChildService child)
        {
            Console.WriteLine("Start ParentService");
            _child = child;

        }
        public void Dispose()
        {
            Console.WriteLine("Dispose ParentService");
            _child.Dispose();
        }
    }

    public class ChildService : IDisposable
    {
        public ChildService()
        {
            Console.WriteLine("Start ChildService");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose ChildService");
        }
    }
}
