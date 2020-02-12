using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mocksome.Client
{
    public class Request
    {
        public Request()
        {
            Headers = new Dictionary<string, string>();
        }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; private set; }

        [JsonProperty("body")]
        [JsonConverter(typeof(LiteralStringConverter))]
        public string Body { get; internal set; }
    }
}
