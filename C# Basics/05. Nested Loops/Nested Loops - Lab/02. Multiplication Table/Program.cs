using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 10; num++)
            {
                for (int multiplicator = 1; multiplicator <= 10; multiplicator++)
                {
                    int result = num * multiplicator;
                    Console.WriteLine($"{num} * {multiplicator} = {result}");
            }
            }
        }
    }
}
