using System;
using Newtonsoft.Json;

namespace Mocksome.Client.Query
{
    public class Path : IComponentQuery
    {
        public Path(string value)
        {
            this.value = value;
        }

        public string value { get; private set; }

        public void Apply(Expectation expectation)
        {
            expectation.Request.Path = value;
        }
    }
}
