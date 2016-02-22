using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyForContainer
{
    public class IndexModule:NancyModule
    {
        public IndexModule()
        {
            Get["/version"] = parameters =>
            {
                Dictionary<String, String> result = new Dictionary<string, string>();
                result.Add("Version", "1.0.0");
                return Response.AsJson(result);
            };
        }
    }
}
