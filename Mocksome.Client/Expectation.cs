using Newtonsoft.Json;

namespace Mocksome.Client
{
    public class Expectation
    {
        [JsonProperty("request")]
        public Request Request { get; private set; }

        [JsonProperty("response")]
        public Response Response { get; }

        public Expectation()
        {
            this.Request = new Request();
            this.Response = new Response();
        }
    }
}
