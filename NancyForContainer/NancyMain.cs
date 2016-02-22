using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyForContainer
{
    class NancyMain
    {
        private Uri _uri = new Uri(@"http://localhost:8080");
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
