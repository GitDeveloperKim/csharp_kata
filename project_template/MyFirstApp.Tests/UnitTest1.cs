using Xunit;
using MyFirstApp;

namespace MyFirstApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = new Program().Greet("World");
            Assert.Equal("Hello, World!", result);
        }
    }
}
