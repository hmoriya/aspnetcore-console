using System;
using System.Collections.Generic;
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
            using (var parent = provider.GetService<ParentService>())
            {
            // so something with the class
            }
            // 5times 
            var parents = new List<ParentService>();
            for (int i = 0; i < 2; i++)
            {
                parents.Add(provider.GetService<ParentService>());
                
                
            }
            foreach (var item in parents)
            {
                item.Dispose();
                
            }
            Console.WriteLine("Service Count: {0}",parents.Count);
        }
    }

    public class ParentService : IDisposable
    {
        private readonly string _name;
        private ChildService _child;
        public ParentService(ChildService child)
        {
            
            _name = DateTime.Now.Ticks.ToString();
            Console.WriteLine("Start ParentService {0}",_name);
            _child = child;
            _child.Hello(_name);

        }
        public void Dispose()
        {
            Console.WriteLine("Dispose ParentService {0}",_name);
            _child.Dispose();
        }
    }

    public class ChildService : IDisposable
    {
        private string _name = "none";
        public ChildService()
        {
            Console.WriteLine("Start ChildService");
        }
        public void Hello(string name){
            _name = name;
            Console.WriteLine("Hello ChildService {0}",_name);

        }
        public void Dispose()
        {
            Console.WriteLine("Dispose ChildService {0}",_name);
        }
    }
}
