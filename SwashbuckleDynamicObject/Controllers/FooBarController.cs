using System.Dynamic;
using System.Web.Http;
using Newtonsoft.Json;

namespace SwashbuckleDynamicObject.Controllers
{
    // [JsonObject]
    public class FooBar : DynamicObject
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
    }

    public class FooBarController : ApiController
    {
        public FooBar Get()
        {
            return new FooBar { Foo="Foo", Bar=123};
        }
    }
}
