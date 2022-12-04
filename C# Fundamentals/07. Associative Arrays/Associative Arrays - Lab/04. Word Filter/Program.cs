using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            List<string> filteredWords = words.Where(words => words.Length % 2 == 0).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, filteredWords));
        }
    }
}
