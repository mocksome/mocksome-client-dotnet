namespace Mocksome.Client
{
    public class Header : IComponentQuery
    {
        private readonly string key;
        private readonly string value;

        public Header(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public void Apply(Expectation expectation)
        {
            expectation.Request.Headers.Add(key, value);
        }
    }
}
