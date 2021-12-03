using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App._2021
{
    public class Dec2
    {
        public static int SolutionPart1(string[] inputArray)
        {
            var horizontalMovement = 0;
            var verticalMovement = 0;

            var directions = ParseDirection(inputArray);

            foreach (var (direction, steps) in directions)
            {
                if (direction == Direction.Horizontal)
                    horizontalMovement += steps;
                else
                    verticalMovement += steps;
            }

            return horizontalMovement*verticalMovement;
        }

        public static int SolutionPart2(string[] inputArray)
        {
            var horizontalMovement = 0;
            var verticalMovement = 0;
            var aim = 0;

            var directions = ParseDirection(inputArray);

            foreach (var (direction, steps) in directions)
            {
                if (direction == Direction.Vertical)
                    aim += steps;
                else
                {
                    horizontalMovement += steps;
                    verticalMovement += aim*steps;
                }
            }

            return horizontalMovement * verticalMovement;
        }

        public static List<(Direction direction, int steps)> ParseDirection(string[] inputArray)
        {
            var directions = new List<(Direction direction, int steps)>();

            foreach (var input in inputArray)
            {
                var inputSplit = input.Split(' ');
                switch (inputSplit[0].ToLowerInvariant())
                {
                    case "forward":
                        directions.Add(new (Direction.Horizontal,Convert.ToInt32(inputSplit[1])));
                        break;
                    case "backward":
                        directions.Add(new(Direction.Horizontal, Convert.ToInt32(inputSplit[1])*-1));
                        break;
                    case "up":
                        directions.Add(new(Direction.Vertical, Convert.ToInt32(inputSplit[1]) * -1));
                        break;
                    case "down":
                        directions.Add(new(Direction.Vertical, Convert.ToInt32(inputSplit[1])));
                        break;
                }
            }

            return directions;
        }
    }

    public enum Direction
    {
        Horizontal,
        Vertical
    }
}
