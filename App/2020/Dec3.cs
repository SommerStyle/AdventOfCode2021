using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App._2020
{
    public class Dec3
    {
        public static int SolutionPart1(String[] inputArray,int aX, int aY)
        {
            return CountTrees(inputArray, aX, aY);
        }

        public static int SolutionPart2(String[] inputArray, List<(int aX, int aY)> listOfPaths)
        {
            return listOfPaths.Aggregate(1, (current, path) => current * CountTrees(inputArray, path.aX, path.aY));
        }

        private static int CountTrees(string[] inputArray, int aX, int aY)
        {
            List<(int y, int x)> coordinates = new List<(int x, int y)>();
            var x = 1;
            for (var y = 1; y < inputArray.Length; y += aY)
            {
                var lineChars = inputArray[y].ToCharArray();
                x += aX;
                if (x > 31)
                    x -= 31;

                if (lineChars[x - 1] == '#')
                    coordinates.Add(new(y + 1, x));
            }

            return coordinates.Count;
        }
    }
}
