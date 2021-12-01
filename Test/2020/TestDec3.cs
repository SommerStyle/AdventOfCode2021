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
    public class TestDec3 : TestBase
    {
        public TestDec3(ITestOutputHelper output) : base(output)
        {
        }
        
        [Fact]
        public void TestSolutionPart1()
        {
            var result = Dec3.SolutionPart1(File.ReadAllLines("2020/data/Dec3_input.txt"), 3, 1);

            Assert.True(result > 0);
            Assert.Equal(167, result);

            output.WriteLine($"Number of trees: {result}");
        }


        [Fact]
        public void TestSolutionPart2a()
        {
            var listOfPaths = new List<(int aX, int aY)>
            {
                (3,1),
            };

            var result = Dec3.SolutionPart2(File.ReadAllLines("2020/data/Dec3_input.txt"), listOfPaths);

            Assert.True(result > 0);
            Assert.Equal(167, result);

            output.WriteLine($"Number of trees: {result}");
        }

        [Fact]
        public void TestSolutionPart2b()
        {
            var listOfPaths = new List<(int aX, int aY)>
            {
                (3,1),
                (3,1)
            };

            var result = Dec3.SolutionPart2(File.ReadAllLines("2020/data/Dec3_input.txt"), listOfPaths);

            Assert.True(result > 0);
            Assert.Equal(167*167, result);

            output.WriteLine($"Number of trees: {result}");
        }

        [Fact]
        public void TestSolutionPart2()
        {
            var listOfPaths = new List<(int aX, int aY)>
            {
                (1,1),
                (3,1),
                (5,1),
                (7,1),
                (1,2)
            };

            var result = Dec3.SolutionPart2(File.ReadAllLines("2020/data/Dec3_input.txt"), listOfPaths);

            Assert.True(result > 0);

            output.WriteLine($"Number of trees: {result}");
        }
    }
}
