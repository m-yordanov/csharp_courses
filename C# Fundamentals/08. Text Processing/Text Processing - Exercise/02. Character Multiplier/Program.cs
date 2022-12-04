using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            GetStringSum(strings[0], strings[1]);
        }

        private static void GetStringSum(string firstString, string secondString)
        {
            int sum = 0;
            int minLength = Math.Min(firstString.Length, secondString.Length);
            for(int i = 0; i < minLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }
            string longestLengthString = firstString;
            if(longestLengthString.Length < secondString.Length)
            {
                longestLengthString = secondString;
            }
            for(int i = minLength; i < longestLengthString.Length; i++)
            {
                sum += longestLengthString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
