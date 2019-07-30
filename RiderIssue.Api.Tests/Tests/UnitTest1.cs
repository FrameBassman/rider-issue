using System.Linq;
using RiderIssue.Api.Tests.Tests.Fixtures;
using Xunit;

namespace RiderIssue.Api.Tests.Tests
{
    [Collection("Api collection")]
    public class UnitTest1
    {
        private readonly ApiFixture _fixture;

        public UnitTest1(ApiFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public void Test1()
        {
            var eventName = "brave_banach";
            var before = _fixture.Db.Tickets.Select(t => t.EventName == eventName);
            
            Assert.Equal("brave_banach", eventName);
        }
    }
}