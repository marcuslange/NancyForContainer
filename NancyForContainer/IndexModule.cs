using System;
using System.Collections.Generic;
using System.Globalization;
using Nancy;

namespace NancyForContainer
{
    public class IndexModule:NancyModule
    {
        public IndexModule()
        {
            Get["/version"] = parameters =>
            {
                var result = new Dictionary<string, string>
                {
                    { "Version", "1.0.0" }
                };
                return Response.AsJson(result);
            };

            Get["/now"] = parameters =>
            {
                var result = new Dictionary<string, string>
                {
                    { "Now", DateTime.Now.ToString(CultureInfo.InvariantCulture) }
                };
                return Response.AsJson(result);
            };
        }
    }
}
