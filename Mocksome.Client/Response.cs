using Newtonsoft.Json;

namespace Mocksome.Client
{
    public class Response
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        public Response()
        {
        }
    }
}
