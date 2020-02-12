using System.Net.Http;
using System.Threading.Tasks;

namespace Mocksome.Client
{
    public class ExpectationBuilder
    {
        private readonly MocksomeClient client;
        private readonly Expectation expectation;

        public ExpectationBuilder(MocksomeClient client)
        {
            this.client = client;
            this.expectation = new Expectation();
        }

        public ExpectationBuilder With(IComponentQuery query)
        {
            query.Apply(expectation);
            return this;
        }

        public Task<HttpResponseMessage> Create()
        {
            return client.Record(expectation);
        }
    }
}
