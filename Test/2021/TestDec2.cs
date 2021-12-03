using System.Linq;
using App._2021;
using Infrastructure.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Test._2021
{
    public class TestDec2 : TestBase
    {
        public TestDec2(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestSolutionPart1()
        {
            var result = Dec2.SolutionPart1(FileParser.ReadAsStringArray("2021/Input/Dec2.txt"));

            Assert.NotEqual(0,result);
            Assert.Equal(1813801, result);

            output.WriteLine($"Result is: {result}");
        }

        [Fact]
        public void TestSolutionPart2()
        {
            var result = Dec2.SolutionPart2(FileParser.ReadAsStringArray("2021/Input/Dec2.txt"));

            Assert.NotEqual(0, result);

            output.WriteLine($"Result is: {result}");
        }
    }
}