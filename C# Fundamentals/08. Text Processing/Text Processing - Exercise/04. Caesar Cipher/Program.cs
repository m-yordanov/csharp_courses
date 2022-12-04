using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (char c in text)
            {
                int currPosition = c;
                currPosition += 3;
                Console.Write((char)currPosition);
            }
        }
    }
}
