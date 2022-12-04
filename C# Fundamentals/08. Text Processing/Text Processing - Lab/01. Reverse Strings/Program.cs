using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                string reversedLine = string.Empty;
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversedLine += line[i];
                }
                Console.WriteLine($"{line} = {reversedLine}");
            }
        }
    }
}
