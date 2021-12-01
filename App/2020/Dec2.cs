using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App._2020
{
    public class Dec2
    {
        public static List<String> OldSchoolSolution(String[] inputArray)
        {
            var results = new List<String>();

            foreach (var inputPassword in inputArray)
            {
                var policy = inputPassword.Split(':').First();
                var password = inputPassword.Split(':').Last();

                var minOccurrence = Convert.ToInt32(policy.Split('-').First());
                var maxOccurrence = Convert.ToInt32(policy.Split(' ').First().Split('-').Last());
                var letterToCheck = policy.Split(' ').Last().Trim().First();

                var numberOfOccurrencesOfLetter = password.ToCharArray().Count(c => c == letterToCheck);

                if (numberOfOccurrencesOfLetter >= minOccurrence && numberOfOccurrencesOfLetter <= maxOccurrence)
                    results.Add(inputPassword);
            }

            return results;
        }

        public static List<String> OldSchoolSolutionPart2(String[] inputArray)
        {
            var results = new List<String>();

            foreach (var inputPassword in inputArray)
            {
                var policy = inputPassword.Split(':').First();
                var password = inputPassword.Split(':').Last().Trim();

                var firstPosition = Convert.ToInt32(policy.Split('-').First())-1;
                var secondPosition = Convert.ToInt32(policy.Split(' ').First().Split('-').Last())-1;
                var letterToCheck = policy.Split(' ').Last().Trim().First();

                var inputPasswordAsCharArray = password.ToCharArray();
                if (inputPasswordAsCharArray[firstPosition]!=letterToCheck && inputPasswordAsCharArray[secondPosition]==letterToCheck)
                    results.Add(inputPassword);
                if (inputPasswordAsCharArray[firstPosition] == letterToCheck && inputPasswordAsCharArray[secondPosition] != letterToCheck)
                    results.Add(inputPassword);
            }

            return results;
        }
    }
}
