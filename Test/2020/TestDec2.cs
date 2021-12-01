using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App._2020;
using Xunit.Abstractions;
using Xunit;

namespace Test._2020.Data
{
    public class TestDec2 : TestBase
    {
        public TestDec2(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestOldSchoolSolution()
        {
            var results = Dec2.OldSchoolSolution(File.ReadAllLines("2020/data/Dec2_input.txt"));

            Assert.NotNull(results);
            Assert.NotEmpty(results);

            output.WriteLine($"Number of correct password: {results.Count}");
        }

        [Fact]
        public void TestOldSchoolSolutionPart2()
        {
            var results = Dec2.OldSchoolSolutionPart2(File.ReadAllLines("2020/data/Dec2_input.txt"));

            Assert.NotNull(results);
            Assert.NotEmpty(results);

            output.WriteLine($"Number of correct password: {results.Count}");
        }
    }
}
