using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = GetVowelCount(input);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelCount(string input)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach(char letter in input.ToLower())
            {
                if (vowels.Contains(letter))
                {   
                    count++;
                }
            }
            return count;
        }
    }
}
