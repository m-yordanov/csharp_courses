using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.Write(input[0]);
            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input[i + 1] != input[i])
                {
                    Console.Write(input[i+1]);
                }
            }
        }
    }
}
