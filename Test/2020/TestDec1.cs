using App._2020;
using Infrastructure.Parsers;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class TestDec1 : TestBase
    {
        public TestDec1(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestOldSchoolSolution()
        {
            var results = Dec1.OldSchoolSolution(FileParser.ReadAsIntArray("2020/Data/Dec1_input.txt"), 2020);
            var result = results.First();

            Assert.NotNull(results);
            Assert.Single(results.DistinctBy(r => r.result));

            output.WriteLine($"{result.a} multiplied by {result.b} equals {result.result}");
        }

        [Fact]
        public void TestLinqSolution()
        {
            var results = Dec1.LinqSolution(FileParser.ReadAsIntArray("2020/Data/Dec1_input.txt"), 2020);
            var result = results.First();

            Assert.NotNull(results);
            Assert.Single(results.DistinctBy(r => r.result));

            output.WriteLine($"{result.a} multiplied by {result.b} equals {result.result}");
        }

        [Fact]
        public void TestLinqSolutionPart2()
        {
            var results = Dec1.LinqSolutionPart2(FileParser.ReadAsIntArray("2020/Data/Dec1_input.txt"), 2020);
            var result = results.First();

            Assert.NotNull(results);
            Assert.Single(results.DistinctBy(r => r.result));

            output.WriteLine($"{result.a} multiplied by {result.b} multiplied by {result.c} equals {result.result}");
        }
    }
}