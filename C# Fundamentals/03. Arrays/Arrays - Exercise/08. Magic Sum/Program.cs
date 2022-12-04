using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            int pair = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int m = i + 1; m < array.Length; m++)
                {
                    pair = array[i] + array[m];
                    if(pair == number)
                    {
                        Console.WriteLine($"{array[i]} {array[m]}");
                    }
                }
            }
        }
    }
}
