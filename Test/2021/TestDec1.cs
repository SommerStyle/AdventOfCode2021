using System.Linq;
using App._2021;
using Infrastructure.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Test._2021
{
    public class TestDec1 : TestBase
    {
        public TestDec1(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestSolutionPart1()
        {
            var result = Dec1.SolutionPart1(FileParser.ReadAsIntArray("2021/Input/Dec1.txt"));

            Assert.NotEqual(0,result);
            Assert.Equal(1624, result);

            output.WriteLine($"Result is: {result}");
        }

        [Fact]
        public void TestSolutionPart2()
        {
            var result = Dec1.SolutionPart2(FileParser.ReadAsIntArray("2021/Input/Dec1.txt"));

            Assert.NotEqual(0, result);
            Assert.Equal(1653, result);

            output.WriteLine($"Result is: {result}");
        }
    }
}