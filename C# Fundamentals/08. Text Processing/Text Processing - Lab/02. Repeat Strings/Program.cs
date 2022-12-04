using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            foreach (string word in words)
            {
                int wordLength = word.Length;
                for (int i = 0; i < wordLength; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
