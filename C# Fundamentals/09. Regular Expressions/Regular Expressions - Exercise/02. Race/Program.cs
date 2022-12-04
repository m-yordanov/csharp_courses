using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[A-Za-z])|(?<distance>[\d])";
            Regex regex = new Regex(pattern);

            string[] participantsList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> raceResults = new Dictionary<string, int>();


            foreach (string currName in participantsList)
            {
                raceResults.Add(currName, 0);
            }

            string input;
            var name = new StringBuilder();

            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection namesAndDistance = regex.Matches(input);
                int distance = 0;
                foreach (Match match in namesAndDistance)
                {
                    if (int.TryParse(match.Groups["distance"].Value, out int currDistance))
                    {
                        distance += currDistance;
                    }
                    else
                    {
                        string currName = match.Groups["names"].Value;
                        name.Append(currName);
                    }
                }
                if (raceResults.ContainsKey(name.ToString()))
                {
                    raceResults[name.ToString()] += distance;
                }
                name.Clear();
            }

            raceResults = raceResults.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            int i = 1;
            foreach(var (currName, distance) in raceResults)
            {
                if(i == 1)
                {
                    Console.WriteLine($"1st place: {currName}");
                }
                else if(i == 2)
                {
                    Console.WriteLine($"2nd place: {currName}");
                }
                else if(i == 3)
                {
                    Console.WriteLine($"3rd place: {currName}");
                }
                i++;
            }
        }
    }
}
