using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mocksome.Client
{

    public class MocksomeClient
    {
        private readonly string serverUrl;

        public MocksomeClient(String serverUrl)
        {
            this.serverUrl = serverUrl;
        }

        public ExpectationBuilder Expectation()
        {
            return new ExpectationBuilder(this);
        }

        public Task<HttpResponseMessage> Record(Expectation expectation)
        {
            HttpClient client = new HttpClient();

            var json = JsonConvert.SerializeObject(expectation);

            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return client.PostAsync("http://localhost:8080/__record", byteContent);
        }
    }
}
