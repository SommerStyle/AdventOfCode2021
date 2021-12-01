using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class TestBase
    {
        protected readonly ITestOutputHelper output;

        public TestBase(ITestOutputHelper output)
        {
            this.output = output;
        }
    }
}
