using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintValues(first, second);
        }

        private static void PrintValues(char first, char second)
        {
            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    char part = Convert.ToChar(i);
                    Console.Write(part + " ");
                }
            }
            else if (second < first)
            {
                for (int i = second + 1; i < first; i++)
                {
                    char part = Convert.ToChar(i);
                    Console.Write(part + " ");
                }
            }
        }
    }
}
