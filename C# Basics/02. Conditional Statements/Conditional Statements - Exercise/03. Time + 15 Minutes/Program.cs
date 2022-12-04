using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minPlus = min + 15;
            if (minPlus > 59)
            {
                hour++;
                minPlus = Math.Abs(60-minPlus);
            }
            if (hour == 24)
            {
                hour -= 24;
            }
            Console.WriteLine($"{hour}:{minPlus:d2}");
        }
    }
}
