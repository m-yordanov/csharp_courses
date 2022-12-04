using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var word in wordsInput)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }
            var results = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
