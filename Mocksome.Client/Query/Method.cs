using System;
namespace Mocksome.Client.Query
{
    public class Method : IComponentQuery
    {
        private readonly string value;

        public Method(string value)
        {
            this.value = value;
        }

        public void Apply(Expectation expectation)
        {
            expectation.Request.Method = this.value;
        }
    }
}
