using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> charOcc = new Dictionary<char, int>();
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (!charOcc.ContainsKey(c))
                    {
                        charOcc.Add(c, 0);
                    }
                    charOcc[c]++;
                }
            }
            foreach (var item in charOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
