using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App._2020
{
    public class Dec1
    {        

        public static List<(int a, int b, int result)> OldSchoolSolution(int[] inputArray, int matchingSum)
        {
            var results = new List<(int a, int b, int result)>();
            foreach(var a in inputArray)
            {
                foreach(var b in inputArray)
                {
                    if (a + b == matchingSum)
                        results.Add((a, b, a * b));
                }
            }
            return results.ToList();
        }

        public static List<(int a, int b, int result)> LinqSolution(int[] inputArray, int matchingSum)
        {
            return inputArray.SelectMany(a => inputArray, (a, b) => new {a, b})
                .Where(t => t.a + t.b == matchingSum)
                .Select(t => (t.a, t.b, t.a * t.b)).ToList();
        }

        public static List<(int a, int b, int c, int result)> LinqSolutionPart2(int[] inputArray, int matchingSum)
        {
            return inputArray.SelectMany(a => inputArray, (a, b) => new {a, b})
                .SelectMany(t => inputArray, (t, c) => new {t, c})
                .Where(t => t.t.a + t.t.b + t.c == matchingSum)
                .Select(t => (t.t.a, t.t.b, t.c, t.t.a * t.t.b * t.c)).ToList();
        }
    }
}
