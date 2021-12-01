using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App._2021
{
    public class Dec1
    {
        public static int SolutionPart1(int[] inputArray)
        {
            var numberOfIncreases = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > inputArray[i - 1])
                    numberOfIncreases++;
            }

            return numberOfIncreases;
        }

        public static int SolutionPart2(int[] inputArray, int windowsSize=3)
        {
            var numberOfIncreases = 0;
            
            for (var i = 0; i < inputArray.Length-windowsSize; i++)
            {
                var sumA = GetSlidingWindow(i, windowsSize, inputArray);
                var sumB = GetSlidingWindow(i+1, windowsSize, inputArray);

                if (sumB > sumA)
                    numberOfIncreases++;
            }

            return numberOfIncreases;
        }

        private static int GetSlidingWindow(int startingPosition, int windowsSize, int[] inputArray)
        {
            var sumSlidingWindows = 0;

            for (var i = 0; i < windowsSize; i++)
            {
                sumSlidingWindows += inputArray[startingPosition + i];
            }
            
            return sumSlidingWindows;
        }
    }
}
