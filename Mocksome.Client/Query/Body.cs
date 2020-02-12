using System;
namespace Mocksome.Client.Query
{
    public class Body
    {
        public Body()
        {

        }

        public JsonBody Json()
        {
            return new JsonBody();
        }
    }

    public class JsonBody
    {
        public IComponentQuery OK(string body)
        {
            return new JsonBodyQuery(body);
        }
    }

    public class JsonBodyQuery : IComponentQuery
    {
        private readonly string body;

        public JsonBodyQuery(string body)
        {
            this.body = body;
        }

        public void Apply(Expectation expectation)
        {
            expectation.Request.Body = this.body;
        }
    }
}