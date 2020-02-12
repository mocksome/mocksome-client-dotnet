using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using static Mocksome.Client.Queries;

namespace Mocksome.Client.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            MocksomeClient client = new MocksomeClient("http://localhost:8080");

            var result = await client
               .Expectation()
               .With(Path("/somepath"))
               .With(Header("x-test", "somevalue"))
               .With(Method("GET"))
               .With(Body().Json().OK(@"{ ""hello"": ""goodbye"" }"))
               .Create();

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}