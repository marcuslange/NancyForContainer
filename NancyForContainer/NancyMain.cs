using System;
using Nancy.Hosting.Self;

namespace NancyForContainer
{
    class NancyMain
    {
        private readonly Uri _uri = new Uri(@"http://localhost:8080");
        private NancyHost _host;

        public void Start()
        {
            _host = new NancyHost(_uri);
            _host.Start();

            Console.WriteLine("Your application is running on " + _uri);
        }

        public void Stop()
        {
            _host.Stop();
            Console.WriteLine("Your application has stopped");
        }
    }
}
