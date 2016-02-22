using System;
using Nancy.Hosting.Self;
using Topshelf;

namespace NancyForContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<NancyMain>(service =>
                {
                    service.ConstructUsing(name => new NancyMain());
                    service.WhenStarted(nm => nm.Start());
                    service.WhenStopped(nm => nm.Stop());
                });

                config.RunAsLocalSystem();
                config.SetDescription("Nancy-SelfHost example");
                config.SetDisplayName("Nancy-SelfHost Service");
                config.SetServiceName("Nancy-SelfHost");
            });
        }
    }
}
